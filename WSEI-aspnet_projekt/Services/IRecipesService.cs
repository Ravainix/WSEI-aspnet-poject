﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEI_aspnet_projekt.Models;

namespace WSEI_aspnet_projekt.Services
{
	public interface IRecipesService
	{
		public List<Recipe> GetRecipes();
		public Recipe GetRecipe(int id);
		public MyResponse UpdateRecipe(Recipe recipe, string userId);
		public void AddRecipe(Recipe recipe);
		public MyResponse DeleteRecipe(int id, string userId);
		public List<Recipe> GetUserRecipes(string id);
		public void AddRecipeWithIngredients(RecipeWithIngredients recipeWithIngredients, string userId);
		public RecipeWithIngredients GetRecipeWithIngredients(int id);
		public List<Recipe> GetFavoriteRecipes(string userId);
		public MyResponse PostFavoriteRecipe(FavoriteRecipe favoriteRecipe);
		public MyResponse DeleteFavoriteRecipe(FavoriteRecipe favoriteRecipe);
		public MyResponse UpdateRecipeWithIngredients(RecipeWithIngredients recipeWithIngredients, string userId);
		public List<Recipe> GetSortedRecipes(GetRecipeFilter filter);
	}
}
