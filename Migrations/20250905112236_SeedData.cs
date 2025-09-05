using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CookingRecipes.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Cuisine", "Description", "ImageUrl", "Rating", "Servings", "Tips", "Title" },
                values: new object[,]
                {
                    { 1, "Indian", "A flavorful rice dish with spices and mixed vegetables.", "https://i.ytimg.com/vi/Do7ZdUodDdw/maxresdefault.jpg", 4.5, 4, "Serve hot with raita for best taste.", "Veg Biryani" },
                    { 2, "Italian", "Creamy Alfredo pasta with parmesan cheese.", "https://images.aws.nestle.recipes/resized/0a0717810b73a1672a029c29788e557b_creamy_alfredo_pasta_long_left_1200_628.jpg", 4.2000000000000002, 2, "Add garlic bread for extra flavor.", "Pasta Alfredo" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Quantity", "RecipeId", "Unit" },
                values: new object[,]
                {
                    { 1, "Basmati Rice", 250, 1, "grams" },
                    { 2, "Mixed Vegetables", 200, 1, "grams" },
                    { 3, "Biryani Masala", 2, 1, "tbsp" },
                    { 4, "Pasta", 200, 2, "grams" },
                    { 5, "Cream", 100, 2, "ml" },
                    { 6, "Parmesan Cheese", 50, 2, "grams" }
                });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "Instruction", "RecipeId", "StepNumber" },
                values: new object[,]
                {
                    { 1, "Wash and soak rice for 30 mins.", 1, 1 },
                    { 2, "Cook vegetables with spices.", 1, 2 },
                    { 3, "Layer rice and veggies, cook on dum.", 1, 3 },
                    { 4, "Boil pasta until al dente.", 2, 1 },
                    { 5, "Prepare Alfredo sauce with cream and cheese.", 2, 2 },
                    { 6, "Mix pasta with sauce and serve hot.", 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
