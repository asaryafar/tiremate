SELECT     SUM(GL_payment_cash.cash_rendered - GL_payment_cash.change_due) AS Expr1
FROM         GL_payment_cash INNER JOIN
                      GL_payment_deposit ON GL_payment_cash.ID_payment = GL_payment_deposit.ID_payment INNER JOIN
                      service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center
WHERE     (GL_payment_deposit.refer_type = '1') AND (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.payment_type = '1') AND 
                      (dbo.ChangeDate(service_center_head.date_refer) >= '2013/08/01') AND (dbo.ChangeDate(service_center_head.date_refer) <= '2013/08/30')