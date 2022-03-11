﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NUnit_Auto_2022.DataModels.APIModels
{
    [XmlRoot(ElementName = "options")]
    class MapQuestOptionsModel
    {
        [XmlElement(ElementName ="avoids")]
        public List<string> avoids { get; set; }

        [XmlElement(ElementName = "avoidTimedConditions")]
        public bool avoidTimedConditions { get; set;  }

        [XmlElement(ElementName = "doReverseGeocode")]
        public bool doReverseGeocode { get; set; }

        [XmlElement(ElementName = "shapeFormat")]
        public string shapeFormat { get; set; }

        [XmlElement(ElementName = "generalize")]
        public int generalize { get; set;  }

        [XmlElement(ElementName = "routeType")]
        public string routeType { get; set; }

        [XmlElement(ElementName = "timeType")]
        public int timeType { get; set; }

        [XmlElement(ElementName = "locale")]
        public string locale { get; set; }

        [XmlElement(ElementName = "unit")]
        public string unit { get; set; }

        [XmlElement(ElementName = "enhancedNarrative")]
        public bool enhancedNarrative { get; set; }

        [XmlElement(ElementName = "drivingStyle")]
        public int drivingStyle { get; set;  }

        [XmlElement(ElementName = "highwayEfficiency")]
        public float highwayEfficiency { get; set; }


    }
}
