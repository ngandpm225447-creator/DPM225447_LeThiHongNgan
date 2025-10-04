﻿
/// <summary>
/// Lớp 'Memento' – gói trạng thái đã chụp của Originator (bất biến với bên ngoài)
/// </summary>
public class Memento
{
    // Trạng thái được lưu trữ
    string state;

    // Hàm khởi tạo – nhận trạng thái để lưu
    public Memento(string state)
    {
        this.state = state;
    }

    // Chỉ đọc: trả về trạng thái đã lưu
    public string State
    {
        get { return state; }
    }
}
