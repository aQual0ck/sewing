INSERT INTO OrderStage(StageName)
VALUES ('�����'),
('�������'),
('���������'),
('��������'),
('� ������'),
('�������'),
('�������'),
('������������'),
('�����');

INSERT INTO Roles(RoleName)
VALUES ('������������'),
('���������'),
('��������'),
('��������');

INSERT INTO Users(Username, Password, RoleId, FullName)
VALUES ('admin', 'admin', '1', '������� ����� ���������'),
('user', '12345', '4', '��������'),
('user1', '12345', '3', '��������'),
('user2', '12345', '2', '���������');