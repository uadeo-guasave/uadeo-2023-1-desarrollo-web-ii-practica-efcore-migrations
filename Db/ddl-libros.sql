-- Build started...
-- Build succeeded.
CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;

CREATE TABLE "Editoriales" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Editoriales" PRIMARY KEY AUTOINCREMENT,
    "Nombre" TEXT NOT NULL,
    "CorreoElectronico" TEXT NULL,
    "SitioWeb" TEXT NULL,
    "Docimilio" TEXT NOT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20230929152812_createTableEditoriales', '7.0.11');

COMMIT;

BEGIN TRANSACTION;

CREATE TABLE "Autores" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Autores" PRIMARY KEY AUTOINCREMENT,
    "Nombres" TEXT NOT NULL,
    "Apellidos" TEXT NOT NULL
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20231003143737_createTableAutores', '7.0.11');

COMMIT;

BEGIN TRANSACTION;

CREATE TABLE "Libros" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Libros" PRIMARY KEY AUTOINCREMENT,
    "Titulo" TEXT NOT NULL,
    "Edicion" INTEGER NOT NULL,
    "EditorialId" INTEGER NOT NULL,
    CONSTRAINT "FK_Libros_Editoriales_EditorialId" FOREIGN KEY ("EditorialId") REFERENCES "Editoriales" ("Id") ON DELETE CASCADE
);

CREATE INDEX "IX_Libros_EditorialId" ON "Libros" ("EditorialId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20231003150607_createTableLibros', '7.0.11');

COMMIT;


