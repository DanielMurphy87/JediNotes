IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [JediNotes] (
    [ID] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Body] nvarchar(max) NULL,
    [Created] datetime2 NOT NULL,
    [Updated] datetime2 NOT NULL,
    [Owner] nvarchar(max) NOT NULL,
    [JediRank] nvarchar(max) NULL,
    CONSTRAINT [PK_JediNotes] PRIMARY KEY ([ID])
);
GO

INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('To Do List', 'Things must I do hmm.', GETDATE(), GETDATE(), 'Yoda', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Well Hello There', 'I have the high ground.', GETDATE(), GETDATE(), 'Obi Wan Kenobi', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Order 66', 'Execute Order 66', GETDATE(), GETDATE(), 'Anakin Skywalker', 'Padawan')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('What was I doing again', 'I forgot...', GETDATE(), GETDATE(), 'Mace Windu', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('How to become a Master', '1. Build lightsaber', GETDATE(), GETDATE(), 'Bardan Dahn', 'Knight')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('How to build a lightsaber', '1. Find crystal', GETDATE(), GETDATE(), 'Icarus Aldan', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Where did Alderaan go?', 'It was there a moment ago.', GETDATE(), GETDATE(), 'Tenal Ran', 'Padawan')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Top 10 Reasons to go to Alderaan', 'Princess Leia', GETDATE(), GETDATE(), 'Obi Wan Kenobi', 'Master')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('Where did I leave my robe?', 'Seriously, I am so forgetful', GETDATE(), GETDATE(), 'Rylekar Hurgreg', 'Knight')
INSERT INTO JediNotes (Title, Body, Created, Updated, Owner, JediRank) VALUES('My Shopping List', 'Colo Claw Fish', GETDATE(), GETDATE(), 'Rylimer Lerfee', 'Master')
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221205125109_Init', N'7.0.0');
GO

COMMIT;
GO

