

 CREATE  INDEX [IX_GL_payment_deposit_1] ON [dbo].[GL_payment_deposit]([refer_type]) ON [PRIMARY]
GO

 CREATE  INDEX [IX_GL_payment_deposit_2] ON [dbo].[GL_payment_deposit]([payment_type]) ON [PRIMARY]
GO

 CREATE  INDEX [IX_service_center_head_1] ON [dbo].[service_center_head]([date_refer]) ON [PRIMARY]
GO
