//using Permisos.Application.Common.Interfaces;
//using Permisos.Application.PermisoLists.Queries.ExportPermisos;
//using Permisos.Infrastructure.Files.Maps;
//using CsvHelper;
//using System.Collections.Generic;
//using System.IO;

//namespace Permisos.Infrastructure.Files
//{
//    public class CsvFileBuilder : ICsvFileBuilder
//    {
//        public byte[] BuildPermisoItemsFile(IEnumerable<PermisoItemRecord> records)
//        {
//            using var memoryStream = new MemoryStream();
//            using (var streamWriter = new StreamWriter(memoryStream))
//            {
//                using var csvWriter = new CsvWriter(streamWriter);

//                csvWriter.Configuration.RegisterClassMap<PermisoItemRecordMap>();
//                csvWriter.WriteRecords(records);
//            }

//            return memoryStream.ToArray();
//        }
//    }
//}
