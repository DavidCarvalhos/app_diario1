using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using app_diario.Models;
using SQLite;

namespace app_diario.Data
{
    public class NotaDatabase
    {
        readonly SQLiteAsyncConnection Database;

        public NotaDatabase(string dbPath)
        {
            Database = new SQLiteAsyncConnection(dbPath);
            Database.CreateTableAsync<nota>().Wait();
        }

        public Task<List<nota>> GetNotaAsynsc()
        {
            //pegar as notas
            return Database.Table<nota>().ToListAsync();
        }

        public Task<nota> GetNotaAsync(int id)
        {
            //pegar uma nota especifica
            return Database.Table<nota>()
                .Where(i => i.ID== id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveNotaAsync(nota nota)
        {
            if (nota.ID !=0)
            {
                //atualizar uma nota 
                return Database.UpdateAsync(nota);
            }
            else
            {
                //salvar nota
                return Database.InsertAsync(nota);
            }
        }
    }
    public Task<int> DeleteNotaAsync(nota nota)
    {
        //deletar
        return database.DeleteAsync(nota);
    }
}
