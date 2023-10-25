using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrisisManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Users_UsersId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Workflows_WorkflowStages_WorkflowStagesId",
                table: "Workflows");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowStages_WorkflowTasks_WorkflowTasksId",
                table: "WorkflowStages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowTasks_Users_UsersId",
                table: "WorkflowTasks");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "WorkflowTasks",
                newName: "AssigneesId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowTasks_UsersId",
                table: "WorkflowTasks",
                newName: "IX_WorkflowTasks_AssigneesId");

            migrationBuilder.RenameColumn(
                name: "WorkflowTasksId",
                table: "WorkflowStages",
                newName: "TasksId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowStages_WorkflowTasksId",
                table: "WorkflowStages",
                newName: "IX_WorkflowStages_TasksId");

            migrationBuilder.RenameColumn(
                name: "WorkflowStagesId",
                table: "Workflows",
                newName: "StagesId");

            migrationBuilder.RenameIndex(
                name: "IX_Workflows_WorkflowStagesId",
                table: "Workflows",
                newName: "IX_Workflows_StagesId");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Departments",
                newName: "DeptHeadsId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_UsersId",
                table: "Departments",
                newName: "IX_Departments_DeptHeadsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Users_DeptHeadsId",
                table: "Departments",
                column: "DeptHeadsId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workflows_WorkflowStages_StagesId",
                table: "Workflows",
                column: "StagesId",
                principalTable: "WorkflowStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowStages_WorkflowTasks_TasksId",
                table: "WorkflowStages",
                column: "TasksId",
                principalTable: "WorkflowTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowTasks_Users_AssigneesId",
                table: "WorkflowTasks",
                column: "AssigneesId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Users_DeptHeadsId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Workflows_WorkflowStages_StagesId",
                table: "Workflows");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowStages_WorkflowTasks_TasksId",
                table: "WorkflowStages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowTasks_Users_AssigneesId",
                table: "WorkflowTasks");

            migrationBuilder.RenameColumn(
                name: "AssigneesId",
                table: "WorkflowTasks",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowTasks_AssigneesId",
                table: "WorkflowTasks",
                newName: "IX_WorkflowTasks_UsersId");

            migrationBuilder.RenameColumn(
                name: "TasksId",
                table: "WorkflowStages",
                newName: "WorkflowTasksId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkflowStages_TasksId",
                table: "WorkflowStages",
                newName: "IX_WorkflowStages_WorkflowTasksId");

            migrationBuilder.RenameColumn(
                name: "StagesId",
                table: "Workflows",
                newName: "WorkflowStagesId");

            migrationBuilder.RenameIndex(
                name: "IX_Workflows_StagesId",
                table: "Workflows",
                newName: "IX_Workflows_WorkflowStagesId");

            migrationBuilder.RenameColumn(
                name: "DeptHeadsId",
                table: "Departments",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_DeptHeadsId",
                table: "Departments",
                newName: "IX_Departments_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Users_UsersId",
                table: "Departments",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workflows_WorkflowStages_WorkflowStagesId",
                table: "Workflows",
                column: "WorkflowStagesId",
                principalTable: "WorkflowStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowStages_WorkflowTasks_WorkflowTasksId",
                table: "WorkflowStages",
                column: "WorkflowTasksId",
                principalTable: "WorkflowTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowTasks_Users_UsersId",
                table: "WorkflowTasks",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
