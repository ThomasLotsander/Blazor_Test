using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.DataAccessLayer;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Services
{
    public class JokeService
    {
        private readonly Context _context;

        public JokeService(Context context)
        {
            _context = context;
        }

        public async Task<Joke> GetRandomJoke(bool acceptExplicit = false)
        {
            try
            {
                var rnd = new Random();
                var jokes = await GetJokes(acceptExplicit);

                var joke = jokes[rnd.Next(0, jokes.Count)];
                return joke;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async Task<List<Joke>> GetJokes(bool acceptExplicit = false)
        {
            try
            {
                var jokes = await _context.Jokes.ToListAsync();
                if (!acceptExplicit)
                    jokes = jokes.Where(x => x.IsExplicit != true).ToList();

                return jokes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
