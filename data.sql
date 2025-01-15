INSERT INTO OrderStage(StageName)
VALUES ('Новый'),
('Ожидает'),
('Обработка'),
('Отклонен'),
('К оплате'),
('Оплачен'),
('Раскрой'),
('Производство'),
('Готов');

INSERT INTO Roles(RoleName)
VALUES ('Руководитель'),
('Кладовщик'),
('Менеджер'),
('Заказчик');

INSERT INTO Users(Username, Password, RoleId, FullName)
VALUES ('admin', 'admin', '1', 'Админов Админ Админович'),
('user', '12345', '4', 'заказчик'),
('user1', '12345', '3', 'менеджер'),
('user2', '12345', '2', 'кладовщик');