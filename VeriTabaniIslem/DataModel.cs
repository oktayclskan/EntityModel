﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace VeriTabaniIslem
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.MConstr);
            cmd = con.CreateCommand();
        }

        public bool KategoriEkle(Kategoriler k)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Kategoriler (KategoriTur)Values (@kategoriTur)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kategoriTur", k.KategoriTur);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        
        public bool BisikletEkle(Bisikletler b)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Bisikletler(Marka,Model,Agırlık,Kategori_ID,Suspansiyon_ID,Renk_ID,Vites_ID,Govde_ID,Fiyat)VALUES (@marka,@model,@agırlık,@kategoriID,@suspansiyonID,@renkID,@vitesID,@govdeID,@fiyat)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@marka",b.Marka);
                cmd.Parameters.AddWithValue("@model", b.Model);
                cmd.Parameters.AddWithValue("@agırlık", b.Agırlık);
                cmd.Parameters.AddWithValue("@kategoriID", b.KategoriID);
                cmd.Parameters.AddWithValue("@suspansiyonID", b.SuspansiyonID);
                cmd.Parameters.AddWithValue("@renkID", b.RenkID);
                cmd.Parameters.AddWithValue("@vitesID", b.VitesID);
                cmd.Parameters.AddWithValue("@govdeID", b.GovdeID);
                cmd.Parameters.AddWithValue("@fiyat", b.Fiyat);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Kategoriler> KategoriListele()
        {
            List<Kategoriler> kategoriler = new List<Kategoriler>();
            try
            {
                cmd.CommandText = "SELECT ID,KategoriTur FROM Kategoriler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategoriler k = new Kategoriler();
                    k.ID = reader.GetInt32(0);
                    k.KategoriTur = reader.GetString(1);
                    kategoriler.Add(k);
                }
                return kategoriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Suspansiyonlar> SuspansiyonListele()
        {
            List<Suspansiyonlar> suspansiyonlar = new List<Suspansiyonlar>();
            try
            {
                cmd.CommandText = "SELECT ID,Marka,Model,Fiyat FROM Suspansiyonlar ";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    Suspansiyonlar s = new Suspansiyonlar();
                    s.ID = reader.GetInt32(0);
                    s.Marka = reader.GetString(1);
                    s.Model = reader.GetString(2);
                    s.Fiyat = reader.GetDecimal(3);
                    suspansiyonlar.Add(s);
                }
                return suspansiyonlar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Renkler> RenkListele()
        {
            List<Renkler> renkler = new List<Renkler>();
            try
            {
                cmd.CommandText = "SELECT ID,Renk FROM Renkler";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Renkler r = new Renkler();
                    r.ID = reader.GetInt32(0);
                    r.Renk = reader.GetString(1);
                    renkler.Add(r);
                }
                return renkler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<GovdeTurleri> GovdeTurListele()
        {
            List<GovdeTurleri> govdeturleri = new List<GovdeTurleri>();
            try
            {
                cmd.CommandText = "SELECT ID,Govde_Tur FROM GovdeTur";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GovdeTurleri g = new GovdeTurleri();
                    g.ID = reader.GetInt32(0);
                    g.Govdetur = reader.GetString(1);
                    govdeturleri.Add(g);
                }
                return govdeturleri;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<VitesSecenekler> VitesSecenekListele()
        {
            List<VitesSecenekler> vitesSecenekler = new List<VitesSecenekler>();
            try
            {
                cmd.CommandText = "SELECT ID, Vites FROM VitesSecenekler";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    VitesSecenekler vs = new VitesSecenekler();
                    vs.Id = reader.GetInt32(0);
                    vs.Vites = reader.GetString(1);
                    vitesSecenekler.Add(vs);

                }
                return vitesSecenekler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateEt(Bisikletler u)
        {
            try
            {

                cmd.CommandText = "UPDATE Bisikletler (Marka,Model,Agırlık,Kategori_ID,Suspansiyon_ID,Renk_ID,Vites_ID,Govde_ID,Fiyat)VALUES (@marka,@model,@agırlık,@kategoriID,@suspansiyonID,@renkID,@vitesID,@govdeID,@fiyat)";
                cmd.Parameters.AddWithValue("@marka", u.Marka);
                cmd.Parameters.AddWithValue("@model", u.Model);
                cmd.Parameters.AddWithValue("@agırlık", u.Agırlık);
                cmd.Parameters.AddWithValue("@kategoriID", u.KategoriID);
                cmd.Parameters.AddWithValue("@suspansiyonID", u.SuspansiyonID);
                cmd.Parameters.AddWithValue("@renkID", u.RenkID);
                cmd.Parameters.AddWithValue("@vitesID", u.VitesID);
                cmd.Parameters.AddWithValue("@govdeID", u.GovdeID);
                cmd.Parameters.AddWithValue("@fiyat", u.Fiyat);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
            
        }
    }
}

