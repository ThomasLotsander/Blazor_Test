using System.Threading.Tasks;
using Blazor.ViewModels;
using DataAccess.DataAccessLayer;
using DataAccess.Models;
using DataAccess.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Blazor.Services
{
    public class JokeService
    {
        //private readonly DbJokeService _dbJoke;
        private readonly Context _context;

        public JokeService(Context context)
        {
            //_dbJoke = jk;
            _context = context;
        }


        public async Task<Joke> GetRandomJoke(bool acceptExplicit = false)
        {
            return await _context.Jokes.FirstAsync(); //.GetRandomJoke(acceptExplicit);
        }

        public async Task<bool> CreateJoke(JokeViewModel jokeModel)
        {
            var joke = new Joke()
            {
                Premiss = jokeModel.Premiss,
                PunchLine = jokeModel.PunchLine,
                Explanation = jokeModel.Explanation,
                IsExplicit = jokeModel.IsExplicit
            };
            // TODO: Validate joke 
            return false;
            //return await _dbJoke.CreateJoke(joke);
        }
        
       
    }
}
