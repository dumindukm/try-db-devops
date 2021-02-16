BEGIN TRANSACTION;
GO

ALTER TABLE [Products] ADD [Name] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210215161335_product_name', N'5.0.2');
GO

COMMIT;
GO