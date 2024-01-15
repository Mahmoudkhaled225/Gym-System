using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DataAccessLayer.Migrations
{
    public partial class relationship1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_trainees_TrainerId",
                table: "trainees",
                column: "TrainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_trainees_trainers_TrainerId",
                table: "trainees",
                column: "TrainerId",
                principalTable: "trainers",
                principalColumn: "_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainees_trainers_TrainerId",
                table: "trainees");

            migrationBuilder.DropIndex(
                name: "IX_trainees_TrainerId",
                table: "trainees");
        }
    }
}
