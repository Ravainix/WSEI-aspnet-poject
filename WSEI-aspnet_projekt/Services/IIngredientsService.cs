﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_aspnet_projekt.Models;

namespace WSEI_aspnet_projekt.Services
{
	public interface IIngredientsService
	{
		public List<Ingredient> GetIngredients();
		public Ingredient GetIngredient(int id);
		public MyResponse UpdateIngredient(Ingredient ingredient, string userId);
		public MyResponse AddIngredient(Ingredient ingredient, string userId);
		public MyResponse DeleteIngredient(int id, string userId);
	}
}
