using System;
using System.Collections.Generic;

namespace BrustRecipes.Repositories.Entities.Recipes
{
    public class RecipeEntity
    {
        public BaseEntity RecipeBase { get; set; }
        public long RecipeBaseId { get; set; }
        public string RecipeComments { get; set; }
        public long RecipeCost { get; set; }
        public CourseEntity RecipeCourse { get; set; }
        public long RecipeCourseId { get; set; }
        public DifficultyEntity RecipeDifficulty { get; set; }
        public long RecipeDifficultyId { get; set; }
        public string RecipeDirections { get; set; }
        public EthnicityEntity RecipeEthnicity { get; set; }
        public long RecipeEthnicityId { get; set; }
        public long RecipeId { get; set; }
        public List<IngredientEntity> RecipeIngredients { get; set; }
        public DateTime? RecipeModified { get; set; }
        public string RecipeName { get; set; }
        public string RecipeOwner { get; set; }
        // public string RecipePicture { get; set; }
        // public string RecipePictureType { get; set; }
        public PrepTimeEntity RecipePrepTime { get; set; }
        public long RecipePrepTimeId { get; set; }
        public long RecipePrivate { get; set; }
        public long? RecipeServingSize { get; set; }
        public string RecipeSource { get; set; }
        public string RecipeSystem { get; set; }
    }
}