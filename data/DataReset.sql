﻿USE [CuisenieTest];
GO

DELETE FROM  dbo.Ingredients; DBCC CHECKIDENT ('dbo.Ingredients', RESEED, 0);
DELETE FROM  dbo.IngredientSets; DBCC CHECKIDENT ('dbo.IngredientSets', RESEED, 0);
DELETE FROM  dbo.Instructions; DBCC CHECKIDENT ('dbo.Instructions', RESEED, 0);
DELETE FROM  dbo.InstructionSets; DBCC CHECKIDENT ('dbo.InstructionSets', RESEED, 0);
DELETE FROM  dbo.RecipePreference; DBCC CHECKIDENT ('dbo.RecipePreference', RESEED, 0);
DELETE FROM  dbo.Food; DBCC CHECKIDENT ('dbo.Food', RESEED, 0);
DELETE FROM  dbo.Recipes; DBCC CHECKIDENT ('dbo.Recipes', RESEED, 0);

GO