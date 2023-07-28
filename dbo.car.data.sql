SET IDENTITY_INSERT [dbo].[car] ON
INSERT INTO [dbo].[car] ([Id], [type], [model], [quantity_on_stock], [cost_per_day], [description], [image]) VALUES (1, N'city', N'altoA10', 0, 100, N'alto car', <SQLVARIANT>)
INSERT INTO [dbo].[car] ([Id], [type], [model], [quantity_on_stock], [cost_per_day], [description], [image]) VALUES (2, N'sport', N'cameroZL1', 10, 400, N'Chevrolet Camaro', <SQLVARIANT>)
INSERT INTO [dbo].[car] ([Id], [type], [model], [quantity_on_stock], [cost_per_day], [description], [image]) VALUES (3, N'city', N'altoA5', 10, 100, N'alto car', <SQLVARIANT>)
INSERT INTO [dbo].[car] ([Id], [type], [model], [quantity_on_stock], [cost_per_day], [description], [image]) VALUES (4, N'sport', N'cameroZL2', 10, 540, N'Chevrolet Camaro2', <SQLVARIANT>)
SET IDENTITY_INSERT [dbo].[car] OFF
