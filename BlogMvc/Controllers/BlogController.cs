using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMvc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BlogMvc.Models
{
    public class BlogController : Controller
    {
        private readonly BlogMvcContext _context;
        public BlogController(BlogMvcContext context)
        {
            _context = context;
        }

        // GET: Blog
        public async Task<IActionResult>Index()
        {
            return View(await _context.Article.ToListAsync());
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var article = await _context.Article
                .Include(y => y.ArticleTags)
                .ThenInclude(y => y.Tag)
                .FirstOrDefaultAsync(m => m.ID == id);
            

            if (article == null)
                return NotFound();

            return View(article);
        }

        // GET: Blog/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ArticleDate,Content,ArticleTags")] ArticleViewModel articleVM)
        {
            if (ModelState.IsValid)
            {
                // etiket işlemleri
                // etiketleri string array olarak al.
                // her etiket veritabanına eklimi diye bak
                // ekliyse, listeye ekle devam et.
                // değilse veritabanına ekle ve listeleye ekle devam et.
                string[] tagArray = null;
                char[] splitChar = { ',' };
                tagArray = articleVM.ArticleTags.Split(splitChar);

                List<Tag> articleTags = new List<Tag>();

                foreach (var item in tagArray)
                {
                    string strTag = item.Replace(" ", "");
                    bool isTagExist = _context.Tags.Any(x => x.TagName == strTag);

                    if (isTagExist == true) // etiket var listeye ekle
                    {
                        var tag = _context.Tags.FirstOrDefault(x => x.TagName == strTag);
                        articleTags.Add(tag);
                    }
                    else // etiket yok veritabanına ekle
                    {
                        Tag tag = new Tag();
                        tag.TagName = strTag;

                        _context.Add(tag);
                        _context.SaveChanges();

                        articleTags.Add(tag);
                    }
                }


                Article article = new Article();
                article.ArticleContent = articleVM.Content;
                article.ArticleDate = articleVM.ArticleDate;
                article.ArticleTitle = articleVM.Title;
                _context.Add(article);
                await _context.SaveChangesAsync();


                List<ArticleTags> articleTags1 = new List<ArticleTags>();
                foreach (var item in articleTags)
                {
                    ArticleTags at = new ArticleTags();
                    at.ArticleID = article.ID;
                    at.TagID = item.ID;

                    articleTags1.Add(at);
                }

                article.ArticleTags = articleTags1;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(articleVM);
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ArticleTitle,ArticleDate,ArticleContent")] Article article)
        {
            if (id != article.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Article
                .FirstOrDefaultAsync(m => m.ID == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Article.FindAsync(id);
            _context.Article.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Article.Any(e => e.ID == id);
        }
        
      
    }
}