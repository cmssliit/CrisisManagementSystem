using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrisisManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class AgainUpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_WorkflowTasks_AssigneesId",
                table: "WorkflowTasks");

            migrationBuilder.DropIndex(
                name: "IX_WorkflowStages_TasksId",
                table: "WorkflowStages");

            migrationBuilder.DropIndex(
                name: "IX_Workflows_StagesId",
                table: "Workflows");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DeptHeadsId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "AssigneesId",
                table: "WorkflowTasks");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "WorkflowStages");

            migrationBuilder.DropColumn(
                name: "StagesId",
                table: "Workflows");

            migrationBuilder.DropColumn(
                name: "DeptHeadsId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowTasks_AssigneeId",
                table: "WorkflowTasks",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStages_TaskId",
                table: "WorkflowStages",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_StageId",
                table: "Workflows",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DeptHeadId",
                table: "Departments",
                column: "DeptHeadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Users_DeptHeadId",
                table: "Departments",
                column: "DeptHeadId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workflows_WorkflowStages_StageId",
                table: "Workflows",
                column: "StageId",
                principalTable: "WorkflowStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowStages_WorkflowTasks_TaskId",
                table: "WorkflowStages",
                column: "TaskId",
                principalTable: "WorkflowTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkflowTasks_Users_AssigneeId",
                table: "WorkflowTasks",
                column: "AssigneeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Users_DeptHeadId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Workflows_WorkflowStages_StageId",
                table: "Workflows");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowStages_WorkflowTasks_TaskId",
                table: "WorkflowStages");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkflowTasks_Users_AssigneeId",
                table: "WorkflowTasks");

            migrationBuilder.DropIndex(
                name: "IX_WorkflowTasks_AssigneeId",
                table: "WorkflowTasks");

            migrationBuilder.DropIndex(
                name: "IX_WorkflowStages_TaskId",
                table: "WorkflowStages");

            migrationBuilder.DropIndex(
                name: "IX_Workflows_StageId",
                table: "Workflows");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DeptHeadId",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "AssigneesId",
                table: "WorkflowTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TasksId",
                table: "WorkflowStages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StagesId",
                table: "Workflows",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptHeadsId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowTasks_AssigneesId",
                table: "WorkflowTasks",
                column: "AssigneesId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowStages_TasksId",
                table: "WorkflowStages",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Workflows_StagesId",
                table: "Workflows",
                column: "StagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DeptHeadsId",
                table: "Departments",
                column: "DeptHeadsId");

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
    }
}
