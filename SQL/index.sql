use CSDLNC2
GO


CREATE NONCLUSTERED INDEX idx_doitac_dh
ON dbo.DonHang(MaDoiTac)


CREATE NONCLUSTERED INDEX idx_doitac_td
ON dbo.ThucDon(MaDoiTac, TenMonAn)

CREATE UNIQUE INDEX idx_sodienthoai_tk
ON TaiKhoan(SoDienThoai)