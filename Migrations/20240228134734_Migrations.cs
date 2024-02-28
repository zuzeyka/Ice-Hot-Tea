using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slush.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    subscribersCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbCategories",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbCategoriesByAuthors",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCategoriesByAuthors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbCategoriesByUsers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCategoriesByUsers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbCategoriesForGame",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbCategoriesForGame", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbDevelopers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subscribersCount = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    backgroundImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlForNewsPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbDevelopers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbDLCsInShop",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    discount = table.Column<int>(type: "int", nullable: false),
                    previeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    developerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publisherId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoriesId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    languagesId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    systemRequirementsId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlForContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    categories = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbDLCsInShop", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbGameGroups",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGameGroups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbGamesInShops",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    discount = table.Column<int>(type: "int", nullable: false),
                    previeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    developerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publisherId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlForContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    categoriesId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    languagesId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    systemRequirementsId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGamesInShops", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbGroups",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    attachedId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGroups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbLanguages",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbLanguages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbMaximumSystemRequirements",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    freeDiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbMaximumSystemRequirements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbMinimalSystemRequirements",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    freeDiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbMinimalSystemRequirements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbPublishers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subscribersCount = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    backgroundImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlForNewsPage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbPublishers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbSystemRequirements",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    freeDiskSpace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbSystemRequirements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dbUsers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbUsers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "List<object>",
                columns: table => new
                {
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "dbGameGuides",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likesCount = table.Column<int>(type: "int", nullable: false),
                    dislikesCount = table.Column<int>(type: "int", nullable: false),
                    discussionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameGroupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGameGuides", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbGameGuides_dbGameGroups_gameGroupId",
                        column: x => x.gameGroupId,
                        principalTable: "dbGameGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbGameNews",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likesCount = table.Column<int>(type: "int", nullable: false),
                    dislikesCount = table.Column<int>(type: "int", nullable: false),
                    discussionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gameGroupid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGameNews", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbGameNews_dbGameGroups_gameGroupid",
                        column: x => x.gameGroupid,
                        principalTable: "dbGameGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbGameTopics",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    attachedId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GameGroupid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGameTopics", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbGameTopics_dbGameGroups_GameGroupid",
                        column: x => x.GameGroupid,
                        principalTable: "dbGameGroups",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbLanguagesInGame",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    languageId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DLCInShopid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameInShopid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbLanguagesInGame", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbLanguagesInGame_dbDLCsInShop_DLCInShopid",
                        column: x => x.DLCInShopid,
                        principalTable: "dbDLCsInShop",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dbLanguagesInGame_dbGamesInShops_GameInShopid",
                        column: x => x.GameInShopid,
                        principalTable: "dbGamesInShops",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbGroupComments",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    groupId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGroupComments", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbGroupComments_dbGroups_groupId",
                        column: x => x.groupId,
                        principalTable: "dbGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbTopics",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    attachedId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Groupid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbTopics", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbTopics_dbGroups_Groupid",
                        column: x => x.Groupid,
                        principalTable: "dbGroups",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbFriends",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    friendId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbFriends", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbFriends_dbUsers_userId",
                        column: x => x.userId,
                        principalTable: "dbUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbOwnedGames",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ownedGameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbOwnedGames", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbOwnedGames_dbUsers_userId",
                        column: x => x.userId,
                        principalTable: "dbUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbScreenshots",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likesCount = table.Column<int>(type: "int", nullable: false),
                    dislikesCount = table.Column<int>(type: "int", nullable: false),
                    discussionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    screenshotUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GameGroupid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Userid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbScreenshots", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbScreenshots_dbGameGroups_GameGroupid",
                        column: x => x.GameGroupid,
                        principalTable: "dbGameGroups",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dbScreenshots_dbUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "dbUsers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbUserComments",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    authorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbUserComments", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbUserComments_dbUsers_userId",
                        column: x => x.userId,
                        principalTable: "dbUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbVideos",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likesCount = table.Column<int>(type: "int", nullable: false),
                    dislikesCount = table.Column<int>(type: "int", nullable: false),
                    discussionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    videoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GameGroupid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Userid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbVideos", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbVideos_dbGameGroups_GameGroupid",
                        column: x => x.GameGroupid,
                        principalTable: "dbGameGroups",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dbVideos_dbUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "dbUsers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbWishedGames",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ownedGameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbWishedGames", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbWishedGames_dbUsers_userId",
                        column: x => x.userId,
                        principalTable: "dbUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupUser",
                columns: table => new
                {
                    groupsid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    usersid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => new { x.groupsid, x.usersid });
                    table.ForeignKey(
                        name: "FK_GroupUser_dbGroups_groupsid",
                        column: x => x.groupsid,
                        principalTable: "dbGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUser_dbUsers_usersid",
                        column: x => x.usersid,
                        principalTable: "dbUsers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dbGamePosts",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likesCount = table.Column<int>(type: "int", nullable: false),
                    dislikesCount = table.Column<int>(type: "int", nullable: false),
                    discussionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gameGroupid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameTopicid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGamePosts", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbGamePosts_dbGameGroups_gameGroupid",
                        column: x => x.gameGroupid,
                        principalTable: "dbGameGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbGamePosts_dbGameTopics_GameTopicid",
                        column: x => x.GameTopicid,
                        principalTable: "dbGameTopics",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbPosts",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likesCount = table.Column<int>(type: "int", nullable: false),
                    dislikesCount = table.Column<int>(type: "int", nullable: false),
                    discussionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gameId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Topicid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbPosts", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbPosts_dbTopics_Topicid",
                        column: x => x.Topicid,
                        principalTable: "dbTopics",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dbGameComments",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gamePostId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    deleteAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Authorid = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GamePostsid = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbGameComments", x => x.id);
                    table.ForeignKey(
                        name: "FK_dbGameComments_Author_Authorid",
                        column: x => x.Authorid,
                        principalTable: "Author",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dbGameComments_dbGamePosts_GamePostsid",
                        column: x => x.GamePostsid,
                        principalTable: "dbGamePosts",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dbFriends_userId",
                table: "dbFriends",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_dbGameComments_Authorid",
                table: "dbGameComments",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_dbGameComments_GamePostsid",
                table: "dbGameComments",
                column: "GamePostsid");

            migrationBuilder.CreateIndex(
                name: "IX_dbGameGuides_gameGroupId",
                table: "dbGameGuides",
                column: "gameGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_dbGameNews_gameGroupid",
                table: "dbGameNews",
                column: "gameGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_dbGamePosts_gameGroupid",
                table: "dbGamePosts",
                column: "gameGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_dbGamePosts_GameTopicid",
                table: "dbGamePosts",
                column: "GameTopicid");

            migrationBuilder.CreateIndex(
                name: "IX_dbGameTopics_GameGroupid",
                table: "dbGameTopics",
                column: "GameGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_dbGroupComments_groupId",
                table: "dbGroupComments",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_dbLanguagesInGame_DLCInShopid",
                table: "dbLanguagesInGame",
                column: "DLCInShopid");

            migrationBuilder.CreateIndex(
                name: "IX_dbLanguagesInGame_GameInShopid",
                table: "dbLanguagesInGame",
                column: "GameInShopid");

            migrationBuilder.CreateIndex(
                name: "IX_dbOwnedGames_userId",
                table: "dbOwnedGames",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_dbPosts_Topicid",
                table: "dbPosts",
                column: "Topicid");

            migrationBuilder.CreateIndex(
                name: "IX_dbScreenshots_GameGroupid",
                table: "dbScreenshots",
                column: "GameGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_dbScreenshots_Userid",
                table: "dbScreenshots",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_dbTopics_Groupid",
                table: "dbTopics",
                column: "Groupid");

            migrationBuilder.CreateIndex(
                name: "IX_dbUserComments_userId",
                table: "dbUserComments",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_dbVideos_GameGroupid",
                table: "dbVideos",
                column: "GameGroupid");

            migrationBuilder.CreateIndex(
                name: "IX_dbVideos_Userid",
                table: "dbVideos",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_dbWishedGames_userId",
                table: "dbWishedGames",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_usersid",
                table: "GroupUser",
                column: "usersid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbCategories");

            migrationBuilder.DropTable(
                name: "dbCategoriesByAuthors");

            migrationBuilder.DropTable(
                name: "dbCategoriesByUsers");

            migrationBuilder.DropTable(
                name: "dbCategoriesForGame");

            migrationBuilder.DropTable(
                name: "dbDevelopers");

            migrationBuilder.DropTable(
                name: "dbFriends");

            migrationBuilder.DropTable(
                name: "dbGameComments");

            migrationBuilder.DropTable(
                name: "dbGameGuides");

            migrationBuilder.DropTable(
                name: "dbGameNews");

            migrationBuilder.DropTable(
                name: "dbGroupComments");

            migrationBuilder.DropTable(
                name: "dbLanguages");

            migrationBuilder.DropTable(
                name: "dbLanguagesInGame");

            migrationBuilder.DropTable(
                name: "dbMaximumSystemRequirements");

            migrationBuilder.DropTable(
                name: "dbMinimalSystemRequirements");

            migrationBuilder.DropTable(
                name: "dbOwnedGames");

            migrationBuilder.DropTable(
                name: "dbPosts");

            migrationBuilder.DropTable(
                name: "dbPublishers");

            migrationBuilder.DropTable(
                name: "dbScreenshots");

            migrationBuilder.DropTable(
                name: "dbSystemRequirements");

            migrationBuilder.DropTable(
                name: "dbUserComments");

            migrationBuilder.DropTable(
                name: "dbVideos");

            migrationBuilder.DropTable(
                name: "dbWishedGames");

            migrationBuilder.DropTable(
                name: "GroupUser");

            migrationBuilder.DropTable(
                name: "List<object>");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "dbGamePosts");

            migrationBuilder.DropTable(
                name: "dbDLCsInShop");

            migrationBuilder.DropTable(
                name: "dbGamesInShops");

            migrationBuilder.DropTable(
                name: "dbTopics");

            migrationBuilder.DropTable(
                name: "dbUsers");

            migrationBuilder.DropTable(
                name: "dbGameTopics");

            migrationBuilder.DropTable(
                name: "dbGroups");

            migrationBuilder.DropTable(
                name: "dbGameGroups");
        }
    }
}
