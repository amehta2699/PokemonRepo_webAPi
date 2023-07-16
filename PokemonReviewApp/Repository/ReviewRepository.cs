﻿using System;
using PokemonReviewApp.Context;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
	public class ReviewRepository: IReviewRepository
	{
        private readonly ApplicationDbContext _context;

		public ReviewRepository(ApplicationDbContext context)
		{
            _context = context;
		}

        public Review GetReview(int reviewId)
        {
            return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return _context.Reviews.OrderBy(r => r.Id).ToList();
        }

        public ICollection<Review> GetReviewsOfAPokemon(int pokeId)
        {
            return _context.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
        }

        public bool ReviewExists(int reviewId)
        {
            return _context.Reviews.Any(r => r.Id == reviewId);
        }
    }
}

