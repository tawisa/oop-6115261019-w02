using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261019_w02
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLatitude;
        private string buildingLongitude;
        public string BuildingCode
        {
            get { return buildingCode; }
            set { buildingCode = value; }
        }
        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
        public string BuildingLatitude
        {
            get { return buildingLatitude; }
            set { buildingLatitude = value; }
        }
        public string BuildingLongitude
        {
            get { return buildingLongitude; }
            set { buildingLongitude = value; }
        }

        public Building() { }
        public Building(string bc, string bn, string bla, string blo)
        {
            this.buildingCode = bc;
            this.buildingName = bn;
            this.buildingLatitude = bla;
            this.buildingLongitude = blo;
        }

        public override string ToString()
        {
            return this.BuildingCode + this.BuildingName
                + this.BuildingLatitude + this.BuildingLongitude;
        }
    }
}