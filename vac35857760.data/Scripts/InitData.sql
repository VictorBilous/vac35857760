﻿INSERT [dbo].[Issues] ([Id], [Subject]) VALUES (1, N'How to install MS SQL Server')
INSERT [dbo].[Issues] ([Id], [Subject]) VALUES (2, N'Your first C# application')
INSERT [dbo].[Issues] ([Id], [Subject]) VALUES (3, N'None')
INSERT [dbo].[Issues] ([Id], [Subject]) VALUES (4, N'Java language')

INSERT [dbo].[Tags] ([tag]) VALUES (N'Beginner')
INSERT [dbo].[Tags] ([tag]) VALUES (N'DB')
INSERT [dbo].[Tags] ([tag]) VALUES (N'OOP')
INSERT [dbo].[Tags] ([tag]) VALUES (N'Setup')

INSERT [dbo].[Issues_Tags] ([IssueId], [Tag]) VALUES (1, N'DB')
INSERT [dbo].[Issues_Tags] ([IssueId], [Tag]) VALUES (1, N'Setup')
INSERT [dbo].[Issues_Tags] ([IssueId], [Tag]) VALUES (2, N'OOP')
INSERT [dbo].[Issues_Tags] ([IssueId], [Tag]) VALUES (4, N'OOP')
INSERT [dbo].[Issues_Tags] ([IssueId], [Tag]) VALUES (2, N'Beginner')