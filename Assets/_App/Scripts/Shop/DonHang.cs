using System;
using UnityEngine;

[Serializable]
public class DonHang : SanPham
{
    public int donHangID;
}

[Serializable]
public class SanPham
{
    public int ID;
    public Sprite anh;
    [HideInInspector] public Sprite anhHai;
    [HideInInspector] public string thongTin;
    [HideInInspector] public string gia;
    [HideInInspector] public string name;
}