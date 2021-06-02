using System;

namespace MinDef.Models.Messages
{
    public class SensorDataMessage
    {
        public Guid Id { get; set; }
        public double Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid VehicleId { get; set; }
        public string Data { get; set; }
        public DataType DataType { get; set; }

        public SensorDataMessage(Guid id, double altitude, double latitude, double longitude, DateTime timeStamp, Guid vehicleId, string data, DataType dataType)
        {
            Id = id;
            Altitude = altitude;
            Latitude = latitude;
            Longitude = longitude;
            TimeStamp = timeStamp;
            VehicleId = vehicleId;
            Data = data;
            DataType = dataType;
        }
    }
}