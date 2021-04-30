using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Imp.solution;

public class IO
{
    public static void Save(string path, SolutionInfo sln)
    {
        Save(path, SerializeObject(sln));
    }

    private static Stream SerializeObject<T>(T sln)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        MemoryStream memoryStream = new MemoryStream();
        binaryFormatter.Serialize(memoryStream, sln);
        return memoryStream;
    }

    public static void Save(string path, Stream stream)
    {
        try
        {
            byte[] array = new byte[stream.Length];
            using (stream)
            {
                stream.Seek(0L, SeekOrigin.Begin);
                stream.Read(array, 0, array.Length);
            }
            File.WriteAllBytes(path, array);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}
