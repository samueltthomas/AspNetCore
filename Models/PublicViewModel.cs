using System; 
using System.Collections.Generic;

namespace AspNetCore.Models {
    public class Data {
        public static List<string> GetFeatures() {
            var features = new List<string> {"cross-platform","high-performance","open-source"};
            return features;
        }
    }
}