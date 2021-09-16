using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using hakoisland.Data;

namespace hakoisland.Models
{

    public class LoginSelectListItem : SelectListItem
    {
        public LoginSelectListItem()
        {

        }
        public LoginSelectListItem(string name, int islandId)
        {
            this.Name = name;
            this.IslandID = islandId;
        }

        public string Name {
            get;
            set;
        }
        
        public int IslandID
        {
            get;
            set;
        }
    }

    public class SignInModel : LoginSelectListItem
    {
        private HakoIslandDbContext _context;
        public SignInModel() : base()
        {
            this._context = new HakoIslandDbContext();
        }

        public SignInModel(int islandId, string password) : base()
        {
            this.IslandID = islandId;
            this.Password = password;
            this._context = new HakoIslandDbContext();
        }

        public string Password { get; set; }

        private string GetHashPasswordFormDatabase()
        {
            return this._context.Password.Single(d => d.IslandId == this.IslandID).Password1;
        }

        private byte[] ConvertToByteArray(string pass)
        {
            return Encoding.UTF8.GetBytes(pass);
        }

        private byte[] ComputeHash(byte[] data)
        {
            // calc sha256
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(data);
            }
        }
        
        private string ConvertToString(byte[] ba)
        {
            return Encoding.UTF8.GetString(ba);
        }

        private bool Verify(string hash1, string hash2)
        {
            return hash1.Equals(hash2);
        }

        public bool ComputeHashSha256()
        {
            if (this.Password != null)
            {
                string db_hash = this.GetHashPasswordFormDatabase();

                // byte[] bytes = this.ConvertToByteArray(this.Password);
                // bytes = this.ComputeHash(bytes);
                // string passed_hash = this.ConvertToString(bytes);
                string passed_hash = this.Password;

                return this.Verify(db_hash, passed_hash);
            }
            return false;
        }

        public bool ComputeHashSha256(string text)
        {
            this.Password = text;
            return this.ComputeHashSha256();
        }
    }
}