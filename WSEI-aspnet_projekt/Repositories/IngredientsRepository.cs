﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_aspnet_projekt.Data;
using WSEI_aspnet_projekt.Models;

namespace WSEI_aspnet_projekt.Repositories
{
	public class IngredientsRepository : IIngredientsRepository
	{
		ApplicationDbContext _context;

		public IngredientsRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public Ingredient GetIngredient(int id)
		{
			return _context.Ingredients.Find(id);
		}

		public async Task<ActionResult<IEnumerable<Ingredient>>> GetIngredients()
		{
			return await _context.Ingredients.ToListAsync();
		}

		public void PostIngredient(Ingredient ingredient)
		{
			_context.Ingredients.Add(ingredient);
			_context.SaveChanges();
			_context.Entry(ingredient).State = EntityState.Detached;
		}

		public void PutIngredient(Ingredient ingredient)
		{
			_context.Entry(ingredient).State = EntityState.Modified;
			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateConcurrencyException)
			{
				_context.Entry(ingredient).State = EntityState.Detached;
				throw;
			}
		}

		public void DeleteIngredient(Ingredient ingredient)
		{
			_context.Ingredients.Remove(ingredient);
			_context.SaveChanges();
		}
	}
}