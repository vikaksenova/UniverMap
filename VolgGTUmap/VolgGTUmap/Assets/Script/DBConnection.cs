using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Класс для работы с БД.
    /// </summary>
    public class DBConnection
    {
        /// <summary>
        /// Строка подключения к БД.
        /// </summary>
        public string ConnectionString { get; }

        /// <summary>
        /// Создать и проинициализировать объект класса для работы с БД.
        /// </summary>
        /// <param name="databasePath">Путь к файлу с БД.</param>
        public DBConnection(string databasePath)
        {
            if (File.Exists(databasePath))      // Проверяем, что такой файл БД действительно есть
            {
                ConnectionString = "URI=file:" + databasePath;  // Создаём строку подключения к БД
            }
            else
            {
                Debug.LogError($"Файл {databasePath} не существует!");
            }
        }

        /// <summary>
        /// Получить конкретный корпус по Id
        /// </summary>
        /// <param name="id">Идентификатор корпуса для получения.</param>
        /// <returns>Объект корпуса с указанным идентификатором.</returns>
        public Korpus GetKorpus(int id)
        {
            try
            {
                // Проверяем, что смогли создать строку подключения выше и если она пуста, выходим
                if (string.IsNullOrEmpty(ConnectionString))
                    return null;

                // Создаём подключение к БД
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())    // Создаём команду запроса к БД
                    {
                        // В команде указываем параметр - Id и передаём параметр в команду
                        command.CommandText = $"SELECT Name, Address, Phone FROM Korpus WHERE ID_korpus = @id;";

                        command.Parameters.AddWithValue("id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();  // Читаем только один корпус

                            // Создаём объект корпуса и возвращаем
                            return new Korpus(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);

                return null;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Kafedra GetKafedra(int id_kafedra)
        {
            try
            {
                // Проверяем, что смогли создать строку подключения выше и если она пуста, выходим
                if (string.IsNullOrEmpty(ConnectionString))
                    return null;

                // Создаём подключение к БД
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())    // Создаём команду запроса к БД
                    {
                        // В команде указываем параметр - Id и передаём параметр в команду
                        command.CommandText = $"SELECT Name, HeadOf FROM Kafedra WHERE ID_kafedra = @id;";

                        command.Parameters.AddWithValue("id", id_kafedra);

                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();  // Читаем только одну кафедру

                            // Создаём объект кафедры и возвращаем
                            return new Kafedra(reader[0].ToString(), reader[1].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);

                return null;
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////
        public Center GetCenter(int id_center)
        {
            try
            {
                // Проверяем, что смогли создать строку подключения выше и если она пуста, выходим
                if (string.IsNullOrEmpty(ConnectionString))
                    return null;

                // Создаём подключение к БД
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())    // Создаём команду запроса к БД
                    {
                        // В команде указываем параметр - Id и передаём параметр в команду
                        command.CommandText = $"SELECT Name, HeadOf FROM Center WHERE ID_center = @id;";

                        command.Parameters.AddWithValue("id", id_center);

                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();  // Читаем только один центр

                            // Создаём объект центра и возвращаем
                            return new Center(reader[0].ToString(), reader[1].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);

                return null;
            }
        }

        public Employee GetResultSearch(string fullName)
        {
            try
            {
                // Проверяем, что смогли создать строку подключения выше и если она пуста, выходим
                if (string.IsNullOrEmpty(ConnectionString))
                    return null;

                // Создаём подключение к БД
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())    // Создаём команду запроса к БД
                    {
                        // В команде указываем параметр - поле ввода и передаём его в команду
                        command.CommandText = $"SELECT * FROM Employee WHERE FullName LIKE @fullName;";

                        command.Parameters.AddWithValue("fullName", "%" + fullName + "%");

                        using (var reader = command.ExecuteReader())
                        {
                            reader.Read();  // Читаем только одного сотрудника

                            // Создаём объект сотрудника и возвращаем                     
                            return new Employee(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError(ex.Message);

                return null;
            }

        }
    }
}
