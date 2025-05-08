-- Script Date: 5/7/2025 9:37 PM  - ErikEJ.SqlCeScripting version 3.5.2.95
CREATE TABLE [Product] (
  [ID] INTEGER NOT NULL
, [Name] TEXT NOT NULL
, [Category] TEXT DEFAULT (NA) NULL
, [Quantity] INTEGER DEFAULT (0) NOT NULL
, [Price] NUMERIC NOT NULL
, [Supplier] TEXT DEFAULT (NA) NOT NULL
, CONSTRAINT [PK_Product] PRIMARY KEY ([ID])
);
