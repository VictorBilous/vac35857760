CREATE TABLE [dbo].[Issues_Tags](
	[IssueId] [int] NOT NULL,
	[Tag] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Issues_Tags]  WITH CHECK ADD  CONSTRAINT [FK_Issues] FOREIGN KEY([IssueId])
REFERENCES [dbo].[Issues] ([Id])
GO

ALTER TABLE [dbo].[Issues_Tags] CHECK CONSTRAINT [FK_Issues]
GO
ALTER TABLE [dbo].[Issues_Tags]  WITH CHECK ADD  CONSTRAINT [FK_Tags] FOREIGN KEY([Tag])
REFERENCES [dbo].[Tags] ([tag])
GO

ALTER TABLE [dbo].[Issues_Tags] CHECK CONSTRAINT [FK_Tags]