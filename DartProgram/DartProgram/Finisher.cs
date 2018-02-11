using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartProgram
{
    class Finisher
    {
        public string GetFinisher(int myScore)
        {
            switch (myScore)
            {
                case 170: return "T20 + T20 + Bull";
                case 167: return "T20 + T19 + Bull";
                case 164: return "T19 + T19 + Bull";
                case 161: return "T20 + T17 + Bull";
                case 160: return "T20 + T20 + D20";
                case 158: return "T20 + T20 + D19";
                case 157: return "T19 + T20 + D20";
                case 156: return "T20 + T20 + D18";
                case 155: return "T20 + T19 + D19";
                case 154: return "T20 + T18 + D20";
                case 153: return "T20 + T19 + D18";
                case 152: return "T20 + T20 + D16";
                case 151: return "T20 + T17 + D20";
                case 150: return "T20 + T18 + D18";
                case 149: return "T20 + T19 + D16";
                case 148: return "T20 + T20 + D14";
                case 147: return "T20 + T17 + D18";
                case 146: return "T20 + T18 + D16";
                case 145: return "T20 + T15 + D20";
                case 144: return "T20 + T20 + D12";
                case 143: return "T20 + T17 + D16";
                case 142: return "T20 + T14 + D20";
                case 141: return "T20 + T15 + D18";
                case 140: return "T20 + T16 + D16";
                case 139: return "T20 + T13 + D20";
                case 138: return "T20 + T16 + D15";
                case 137: return "T18 + T17 + D16";
                case 136: return "T20 + T20 + D8";
                case 135: return "T20 + T13 + D18";
                case 134: return "T20 + T14 + D16";
                case 133: return "T20 + T19 + D8";
                case 132: return "T20 + T16 + D12";
                case 131: return "T20 + T13 + D16";
                case 130: return "T20 + T18 + D8";
                case 129: return "T19 + T16 + D12";
                case 128: return "T20 + T20 + D4";
                case 127: return "T20 + T17 + D8";
                case 126: return "T19 + 19 + Bull";
                case 125: return "T20 + T19 + D4";
                case 124: return "T20 + T16 + D8";
                case 123: return "T20 + T13 + D12";
                case 122: return "T18 + 18 + Bull";
                case 121: return "T19 + 14 + Bull";
                case 120: return "T20 + 20 + D20";
                case 119: return "T20 + 19 + D20";
                case 118: return "T20 + 18 + D20";
                case 117: return "T20 + 17 + D20";
                case 116: return "T20 + 16 + D20";
                case 115: return "T20 + 15 + D20";
                case 114: return "T20 + 14 + D20";
                case 113: return "T20 + 13 + D20";
                case 112: return "T20 + 12 + D20";
                case 111: return "T20 + 19 + D16";
                case 110: return "T20 + 10 + D20";
                case 109: return "T19 + 12 + D20";
                case 108: return "T20 + 16 + D16";
                case 107: return "T19 + 10 + D20";
                case 106: return "T20 + 10 + D18";
                case 105: return "T20 + 13 + D16";
                case 104: return "T20 + 12 + D16";
                case 103: return "T19 + 10 + D18";
                case 102: return "T20 + 10 + D16";
                case 101: return "T17 + 10 + D20";
                case 100: return "T20 + D20";
                case 99: return "T19 + 10 + D6";
                case 98: return "T20 + D19";
                case 97: return "T19 + D20";
                case 96: return "T20 + D18";
                case 95: return "T19 + D19";
                case 94: return "T18 + D20";
                case 93: return "T19 + D18";
                case 92: return "T20 + D16";
                case 91: return "T17 + D20";
                case 90: return "T18 + D18";
                case 89: return "T19 + D16";
                case 88: return "T16 + D20";
                case 87: return "T17 + D18";
                case 86: return "T18 + D16";
                case 85: return "T15 + D20";
                case 84: return "T16 + D18";
                case 83: return "T17 + D16";
                case 82: return "T14 + D20";
                case 81: return "T15 + D18";
                case 80: return "T16 + D16";
                case 79: return "T13 + D20";
                case 78: return "T18 + D12";
                case 77: return "T15 + D16";
                case 76: return "T20 + D8";
                case 75: return "T13 + D18";
                case 74: return "T14 + D16";
                case 73: return "T19 + D8";
                case 72: return "T16 + D12";
                case 71: return "T13 + D16";
                case 70: return "T18 + D8";
                case 69: return "19 + Bull";
                case 68: return "T20 + D4";
                case 67: return "T17 + D8";
                case 66: return "T10 + D18";
                case 65: return "T19 + D4";
                case 64: return "T16 + D8";
                case 63: return "T13 + D12";
                case 62: return "T10 + D16";
                case 61: return "T15 + D8";
                case 60: return "20 + D20";
                case 59: return "19 + D20";
                case 58: return "18 + D20";
                case 57: return "17 + D20";
                case 56: return "16 + D20";
                case 55: return "15 + D20";
                case 54: return "14 + D20";
                case 53: return "13 + D20";
                case 52: return "12 + D20";
                case 51: return "19 + D16";
                case 50: return "10 + D20";
                case 49: return "17 + D16";
                case 48: return "16 + D16";
                case 47: return "15 + D16";
                case 46: return "6 + D20";
                case 45: return "13 + D16";
                case 44: return "12 + D16";
                case 43: return "3 + D20";
                case 42: return "10 + D16";
                case 41: return "9 + D16";
                case 40: return "D20";

                default: return "";
            }
        }
    }
}
