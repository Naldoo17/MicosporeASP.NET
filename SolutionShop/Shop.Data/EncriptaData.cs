using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class EncriptaData
    {

		public static string Encripta3DES(string cadena, string skey)
		{
			try
			{
				TripleDESCryptoServiceProvider des;
				MD5CryptoServiceProvider hashmd5;

				byte[] keyHash, buff;
				string encriptado;

				hashmd5 = new MD5CryptoServiceProvider();
				keyHash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(skey));

				hashmd5 = null;
				des = new TripleDESCryptoServiceProvider();

				des.Key = keyHash;
				des.Mode = CipherMode.ECB;

				buff = ASCIIEncoding.ASCII.GetBytes(cadena);
				encriptado = Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buff, 0, buff.Length));

				return encriptado;

			}
			catch (Exception)
			{

				return null;
			}
		}


		public static string DesEncripta3DES(string cadena, string skey)
		{
			try
			{
				TripleDESCryptoServiceProvider des;
				MD5CryptoServiceProvider hashmd5;

				byte[] keyHash, buff;
				string desEncriptado;

				hashmd5 = new MD5CryptoServiceProvider();
				keyHash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(skey));

				hashmd5 = null;
				des = new TripleDESCryptoServiceProvider();

				des.Key = keyHash;
				des.Mode = CipherMode.ECB;


				buff = Convert.FromBase64String(cadena);
				desEncriptado = ASCIIEncoding.ASCII.GetString(des.CreateDecryptor().TransformFinalBlock(buff, 0, buff.Length));

				return desEncriptado;
			}
			catch (Exception)
			{

				return null;
			}
		}
	}
}
