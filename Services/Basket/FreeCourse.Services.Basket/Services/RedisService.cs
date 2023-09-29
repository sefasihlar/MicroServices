﻿using StackExchange.Redis;

namespace FreeCourse.Services.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;
        private ConnectionMultiplexer _connectionMultiplexer;
        private readonly int _port;

        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(db);

    }
}
