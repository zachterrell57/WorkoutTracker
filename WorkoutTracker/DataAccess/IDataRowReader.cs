using System;
using WorkoutTracker.Model;

namespace DataAccess
{
   public interface IDataRowReader
   {
      bool Read();
      byte GetByte(string name);
      DateTimeOffset GetDateTimeOffset(string name);
      int GetInt32(string name);

        double GetDouble(string name);

      string GetString(string name);
      T GetValue<T>(string name);
   }
}