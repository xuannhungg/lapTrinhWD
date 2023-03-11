use project_LTWD;
create table Thue (
CCCD varchar(100) NOT NULL,
LoaiThue nvarchar(100),
MucThue real,
TinhTrang nvarchar(50),
CONSTRAINT thue_theo_cccd
FOREIGN KEY (CCCD)
REFERENCES CongDan (cmnd)
)

insert into Thue (CCCD, LoaiThue, MucThue, TinhTrang)
values ('1800456','Thue thu nhap ca nhan',1.5, 'Chua dong');
insert into Thue (CCCD, LoaiThue, MucThue, TinhTrang)
values ('1800457','Thue gia tri gia tang',2.4, 'Chua dong');
insert into Thue (CCCD, LoaiThue, MucThue, TinhTrang)
values ('1800458','Thue gia tri gia tang',3.6, 'Chua dong');

select * from Thue