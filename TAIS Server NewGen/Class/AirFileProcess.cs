using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace TAIS_Server_NewGen.Class
{
    public class AirFileProcess
    {
        //Airline Codes
       private static List<string> IASACode = new List<string>
            {
                "AF", "JL",
                "SU", "KQ", "9W","EY", "LY", "QZ","SQ", "3K", "JQ","9B", "6U", "9T","KI", "JP", "A3","RE", "EI", "EE",
                "EM", "P7", "P5","NJ", "7L", "DW","A4", "AJ", "VB","SU", "KG", "5P","AR", "2K", "N3","P4", "VW", "AM",
                "OT", "WL", "VH","5L", "PQ", "VV","HC", "VJ", "XU","8U", "ZI", "AH","ZX", "A6", "3S","E5", "3O", "BM",
                "KC", "UU", "QN","W9", "BT", "ZQ","AB", "BP", "2J","8Y", "BX", "TV","AC", "TX", "7P","NV", "CV", "CA",
                "A7", "TI", "YN","EN", "ED", "UX","X4", "OF", "AF","GN", "DA", "WV","GL", "NY", "IX","3H", "VU", "JM",
                "NQ", "K7", "JS","WJ", "DR", "L8","NX", "MD", "QM","KM", "6T", "CW","MR", "MK", "ML","P8", "6M", "MC",
                "9U", "SW", "NZ","7A", "VK", "EL","EH", "PX", "4N","YW", "AP", "FJ","PT", "2P", "GZ","PJ", "V7", "HM",
                "4D", "GM", "SZ","YI", "VT", "TN","TC", "TZ", "6C","8T", "TS", "JY","U7", "3N", "DO","NF", "ZW", "UM",
                "AK", "D7", "SB","4F", "KO", "E9","4C", "QP", "P2","A5", "QU", "CG","X6", "TL", "FL","J6", "2B", "6L",
                "6N", "9A", "2T","AS", "J5", "LV","F4", "ZR", "AZ","NH", "G4", "CD","QQ", "C4", "UJ","N6", "K4", "PE",
                "1A", "2D", "2Y","7S", "9S", "9Z","2X", "Z8", "YJ","AA", "AX", "MQ","WD", "2V", "OY","G6", "XD", "5F",
                "FG", "W3", "Q9","OR", "IZ", "U8","R7", "KJ", "OZ","KP", "5W", "ZF","RC", "4X", "EV","TD", "8A", "KK",
                "IQ", "H8", "GR","AU", "OS", "3W","JN", "Z7", "6A","7U", "4A", "AV","AO", "MV", "GU","Q4", "U3", "9V",
                "2Q", "J2", "AD","JA", "CJ", "J4","UP", "BN", "5T","8N", "Y6", "PG","4T", "B2", "JV","L9", "B3", "LZ",
                "A8", "8E", "CH","BG", "NT", "J8","BZ", "SI", "5Z","QW", "4B", "BV","OB", "EB", "WW","FQ", "BD", "5Q",
                "BA", "BQ", "DB","U4", "XV", "SN","UZ", "MO", "FB","VE", "UY", "XM","K6", "KF", "QC","C6", "9K", "3Q",
                "BW", "W8", "V3","RV", "CX", "CE","KX", "XK", "C5","C2", "ZO", "CI","C0", "0C", "G5","6Q", "PN",
                "5B", "9M", "3A","CK", "J7", "B1","CZ", "MG", "KN","X2", "EU", "OQ","A2", "MU", "QI","C9", "CF", "B5",
                "DQ", "9L", "WX","MN", "OH", "O5","CP", "DF", "LK","DE", "C3", "CO","CS", "V0", "CM","SS", "OU", "C8",
                "YL", "CU", "CY","YK", "OK", "CQ","D3", "N2", "9J","DX", "0D", "F7","D5", "JD", "DL","Z9", "3D", "DI",
                "2A", "DZ", "D8","LJ", "Z6", "ZD","7D", "R6", "KA","KB", "9H", "E3","EG", "ZE", "T3","JI", "U2", "DS",
                "WK", "MS", "LY","6S", "E4", "EK","E0", "7H", "B8","2U", "OV", "ET","EY", "6Z", "YU","UI", "GJ", "K2",
                "QY", "RY", "9F","EW", "BR", "3Z","X7", "OW", "5Y","XE", "FE", "F1","F6", "QE", "7V","FX", "FO", "AY",
                "FC", "7F", "DP","5H", "W2", "PA","F5", "BE", "FZ","FY", "7Y", "LF","Q5", "FP", "F9","2F", "JH", "FH",
                "GY", "GC", "GA","4G", "GT", "A9","4L", "ST", "AU","8G", "QG", "Y2","GH", "Z5", "GO","G8", "GK", "G7",
                "G3", "DC", "CN","GV", "ZK", "ZG","6P", "G2", "GF","6G", "3M", "H1","H6", "HR", "HP","HU", "7Z", "4R",
                "2H", "HF", "H3","HQ", "HA", "BH","NS", "YO", "H4","UV", "JB", "HJ","HT", "2L", "IU","EO", "UD", "RX",
                "5K", "8H", "HD","H5", "HB", "HX","UO", "QX", "II","IB", "IP", "FW","X8", "FI", "V8","IK", "6E", "7I",
                "D6", "ID", "3L","IR", "B9", "EP","IA", "WP", "IS","Q2", "IF", "WC","6H", "FS", "OI","GI", "JC", "JO",
                "3X", "JL", "NU","JU", "J9", "QK","7C", "9W", "JF","PP", "S2", "LS","TB", "B6", "10","JQ", "3K", "BL",
                "3B", "R5", "JR","DV", "Y7", "WR","D9", "IH", "5N","E8", "6J", "HO","XC", "N9", "RQ","E2", "5R", "3Y",
                "KT", "KV", "FK","MS", "4K", "KQ","IT", "WA", "KL","KE", "ZC", "GW","KY", "KU", "KR","6K", "QH", "R8",
                "4V", "LR", "TM","LA", "UC", "LU","AM", "XL", "IL","LP", "QV", "QJ","NG", "A0", "W4","HE", "LI", "LN",
                "QL", "JT", "LM","LB", "LO", "XO","LT", "8L", "LH","CL", "S1", "L5","L7", "LG", "5V","L3", "CC", "IN",
                "W5", "M2", "MH","MA", "TF", "RI","AE", "JE", "NM","AQ", "6V", "M7","MP", "6F", "YD","L6", "NR", "L4",
                "MY", "7M", "9Y","VL", "IG", "MZ","YV", "XJ", "MX","QA", "OM", "ME","YX", "AL", "MJ","IM", "6R", "MW",
                "2M", "ZB", "YM","5M", "7B", "3R","M9", "3E", "8M","AI", "IC", "T2","UE", "XY", "7N","NC", "5C", "1L",
                "ZN", "NO", "RA","NE", "9X", "EJ","2N", "JX", "NP","DD", "XH", "N5","NA", "M3", "HW","NW", "2G", "DY",
                "BJ", "S8", "BK","OL", "OA", "OP","WY", "OG", "T6","8Q", "EC", "EA","RF", "R2", "OX","OC", "ON", "OJ",
                "Y5", "3F", "8P","LW", "PK", "PM","7Q", "GP", "HI","P6", "PC", "H9","KS", "P9", "9P","PR", "9E", "PU",
                "Z3", "YQ", "PD","NI", "PW", "GX","PF", "8W", "PB","KD", "SJ", "Z4","QF", "QR", "QO","9G", "RT", "WZ",
                "RD", "RK", "FN","ZL", "QT", "3C","R4", "WE", "C7","WQ", "FV", "RR","AT", "BI", "RL","RJ", "RM", "AW",
                "WB", "FR", "2C","FA", "4Q", "DH","PV", "SO", "MM","ZS", "RZ", "S3","6W", "BU", "HZ","SP", "S4", "9R",
                "SV", "W7", "SK","YR", "CB", "BB","K5", "DN", "8D","5S", "UG", "D2","NL", "SC", "FM","SH", "ZH", "S5",
                "5E", "S7", "3U","FT", "MI", "SQ","1M", "JW", "H2","ZY", "GQ", "XW","QB", "UQ", "ND","Q7", "F3", "BC",
                "LQ", "5G", "XT","JZ", "XR", "OO","ZA", "SX", "M4","QS", "6Y", "2E","PI", "8R", "SL","IE", "4J", "4Z",
                "SA", "XZ", "YG","DG", "PL", "WN","JK", "SG", "NK","SM", "9C", "UL","2S", "7G", "V9","S9", "NB", "DM",
                "8F", "VC", "SD","RN", "S6", "EZ","SY", "XQ", "XG","WG", "PY", "HS","LX", "7E", "RB","DT", "HH", "TA",
                "VR", "R9", "7J","JJ", "PZ", "EQ","4E", "TQ", "TP","K3", "RO", "SF","U9", "RU", "C1","FD", "TG", "T9",
                "MT", "DK", "BY","GS", "3P", "TV","TR", "TT", "T1","ZT", "3V", "K9","OD", "9D", "TJ","WI", "N4", "Q8",
                "M8", "UN", "GE","HV", "PH", "TO","7T", "T4", "2Z","X3", "6B", "TU","3T", "TK", "T5","TW", "T7", "VO",
                "PS", "X5", "UF","B7", "UA", "4H","UB", "UW", "U6","US", "U5", "UT","UR", "HY", "VA","V4", "VF", "VZ",
                "2R", "VN", "4P","VQ", "NN", "BF","V5", "VX", "VS","DJ", "V2", "XF","VG", "Y4", "VI","RG", "VY", "V6",
                "4W", "WT", "KW","WH", "2W", "8O","WS", "WF", "7W","WM", "IW", "8Z","W6", "WU", "WO","Y3", "8V", "MF",
                "XP", "R3", "YC","YH", "Y8", "Y0","IY", "OE", "YT","4Y", "YY", "ZV","ZJ", "K8", "Q3","B4", "Z2", "3J"
            };

        private void Decrypt (string _input, out string result)
        {
            result = "";

            for(int ctr= 0; ctr < _input.Length; ctr++)
            {
                string temp = _input.Substring(ctr, 1);

                if (temp == "J" || temp == "T")
                    result += "0";
                else if (temp == "I" || temp == "S")
                    result += "1";
                else if (temp == "H" || temp == "R")
                    result += "2";
                else if (temp == "G" || temp == "Q")
                    result += "3";
                else if (temp == "F" || temp == "P" || temp == "Z")
                    result += "4";
                else if (temp == "O" || temp == "Y")
                    result += "5";
                else if (temp == "D" || temp == "N" || temp == "X")
                    result += "6";
                else if (temp == "C" || temp == "M" || temp == "W")
                    result += "7";
                else if (temp == "B" || temp == "L" || temp == "V")
                    result += "8";
                else if (temp == "A" || temp == "K" || temp == "U")
                    result += "9";
            }
        }

        public void ReadAirFile(FileInfo file, MainWindow mainWindow)
        {
            //Variables from first gen

            string[] temp;

            string[] bTTemp;

            string[] tkt;

            int ctrLX = 0, found = 0, r, rj, rjf, rTkt;

            int rTInfo, rHotel, rCar;

            int spClt;

            string pStr = "", pCeb = "";

            int xy, rNoPax, p = 0;

            //string EACode = "", Etck = "", NoPax = "";

            List<string> lines = new List<string>();

            List<string> linesNew = new List<string>();

            List<string> Tlines = new List<string>();

            List<string> Alines = new List<string>();

            int x, y, tk = 0, chkSabre;

            string textLine = "";

            //try
            //{
            using (var fileStream = File.OpenRead(file.FullName))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, 128))
                {
                    while (streamReader.Peek() > -1)
                    {
                        //Process

                        textLine = streamReader.ReadLine();

                        lines.Add(textLine);

                        temp = textLine.Split(';');

                        chkSabre = textLine.IndexOf("M6ADT");

                        if (chkSabre > 0)
                            ctrLX = 4;

                        for (x = 0; x < temp.Count(); x++)
                        {
                            //Voided Air Files
                            if (temp[x] == "MA" || temp[x].Contains("VOID"))
                            {
                                List<string> ticketNumbers = new List<string>();

                                while (streamReader.Peek() > -1)
                                {
                                    textLine = streamReader.ReadLine();

                                    if (textLine.Contains("T-"))//TicketNo
                                    {
                                        ticketNumbers.Add(textLine.Substring(textLine.Length - 10, 10));
                                    }
                                }

                                //TravCom Database Connection
                                using (var db = new TravComEntities())
                                {
                                    ticketNumbers.ForEach(ticketNo =>
                                    {
                                        var product = db.IfInvoiceDetails.Where(q => q.TicketNumber == ticketNo).ToList();

                                        if (product.Count > 0)
                                        {
                                            product.ForEach(item =>
                                            {
                                                item.TransactionType = 2;

                                                item.GrossAmount = item.GrossAmount * -1;
                                            });
                                        }

                                    });

                                    db.SaveChanges();
                                }
                            }

                            //Determine if Air File is Cebu Pac or IASA Ticket
                            if (temp[x].Contains("BT") || temp[x].Contains("IM"))
                            {
                                while (streamReader.Peek() > -1)
                                {
                                    textLine = streamReader.ReadLine();

                                    r = textLine.IndexOf(";ET;");

                                    rj = textLine.IndexOf(";N;;");

                                    rjf = textLine.IndexOf(";FLWN;");

                                    if (r > 0 || rj > 0 || rjf > 0)
                                    {
                                        textLine = textLine.Replace("U-", "H-").Replace("X;", ";");

                                        lines.Add(textLine);
                                    }
                                    else
                                        lines.Add(textLine);

                                    rNoPax = textLine.IndexOf("I-0");

                                    if (rNoPax > 0)
                                        p++;

                                    //Insert Ticket Number and Airline Code from Air File
                                    rTkt = textLine.IndexOf("ETCK");

                                    if (rTkt > 0)
                                    {
                                        tkt = textLine.Split('-');

                                        Alines.Add(tkt[0].Substring(7, 3));

                                        Tlines.Add(tkt[1]);
                                    }

                                    rTInfo = textLine.IndexOf("INSR");

                                    rHotel = textLine.IndexOf(";RTT-;");

                                    rCar = textLine.IndexOf("CCR-;");

                                    if (rTInfo > 0)
                                        pCeb = "OTHER";
                                    else if (rHotel > 0)
                                        pCeb = "HOTEL";
                                    else if (rCar > 0)
                                        pCeb = "IASA";

                                    //Condition to check if Cebu Pac Tickets
                                    if (textLine.Contains("H-"))
                                    {
                                        if (textLine.Contains(";5J"))
                                            pCeb = "CebuPac";
                                        else if (CheckIfIASA(textLine))
                                            pCeb = "IASA";
                                    }//end of If clause                                     
                                }//end of while loop
                            }//end of if else "BT or "IM"

                            //IATA Tickets
                            if (temp[x].Contains("7A") && !temp[x].Contains("IM"))
                            {
                                while (streamReader.Peek() > -1)
                                {
                                    textLine = streamReader.ReadLine();

                                    rNoPax = textLine.IndexOf("I-0");

                                    if (rNoPax > 0)
                                        p++;

                                    lines.Add(textLine);

                                    bTTemp = textLine.Split(';');

                                    for (y = 0; y < bTTemp.Count(); y++)
                                    {
                                        if (bTTemp[y] != "")
                                        {
                                            ctrLX = GetCTRLX(textLine);
                                        }
                                    } //end of for loop

                                }//end of while loop

                            }//end of if else

                        }//end of for loop
                    }//end of while loop (reader - 1)




                    if (pCeb == "CebuPac")
                    {
                        int ctr = 0;

                        using (var streamWriter = File.CreateText(mainWindow.txtBoxCebuPacificLocationPath.Text
                            + "\\" + file.Name))
                        {
                            for (xy = 0; xy < lines.Count(); xy++)
                            {
                                if (xy == lines.Count - 1)
                                {
                                    streamWriter.WriteLine("ENDX");

                                    streamWriter.Close();

                                    break;
                                }


                                if (lines[xy].Contains("TKOK") ||
                                    lines[xy].Contains("TKTL"))
                                {
                                    if (lines[xy].Contains("TKOK"))
                                    {
                                        var tktDate = lines[xy].Substring(4, 5);

                                        DateTime date = DateTime.Parse(tktDate);

                                        streamWriter.WriteLine("RM*FF65/" + string.Format("{0:MM-dd-yy}", date));
                                    }

                                    streamWriter.WriteLine("T-K" + Alines[ctr] + "-" +
                                        Tlines[ctr]);

                                    streamWriter.WriteLine("RM*ET/" + Tlines[ctr]);

                                    streamWriter.WriteLine("RM*NA" + Alines[ctr] + "/PC1/V10000029");

                                    ctr++;
                                }
                                else if (lines[xy].Contains("RM*FOP/CC/"))
                                {
                                    string tempCC = lines[xy].Substring(10, lines[xy].Length - 17);

                                    string decrpytedCC = "";

                                    Decrypt(tempCC, out decrpytedCC);

                                    var tempExpDate = lines[xy].Substring(lines[xy].Length - 7, 7);

                                    streamWriter.WriteLine("RM*FOP/CC/" + decrpytedCC + tempExpDate);
                                }
                                else
                                    streamWriter.WriteLine(lines[xy]);

                            }

                            streamWriter.Close();
                        }
                    }
                    else if (pCeb == "HOTEL")
                    {
                        int UH = 0;

                        int chkHHL = 0;

                        for (int yx = 0; yx < lines.Count; yx++)
                        {
                            if (lines[yx].Contains("HHL") || lines[yx].Contains("CCR"))
                                chkHHL = 1;
                        }

                        if (chkHHL == 1)
                        {
                            using (var streamWriter = File.CreateText(mainWindow.txtBoxOtherInfoPath.Text + "\\" + file.Name))
                            {
                                for (xy = 0; xy < lines.Count; xy++)
                                {
                                    if (lines[xy].Contains("H-"))
                                        streamWriter.WriteLine(lines[xy].Replace("H-", "U-"));
                                    else if (lines[xy].Contains("RM*FOP/CC/"))
                                    {
                                        string tempCC = lines[xy].Substring(10, lines[xy].Length - 17);

                                        string decrpytedCC = "";

                                        Decrypt(tempCC, out decrpytedCC);

                                        var tempExpDate = lines[xy].Substring(lines[xy].Length - 7, 7);

                                        streamWriter.WriteLine("RM*FOP/CC/" + decrpytedCC + tempExpDate);
                                    }
                                    else
                                        streamWriter.WriteLine(lines[xy]);
                                }

                                streamWriter.Close();
                            }
                        }
                    }
                    else if (pCeb == "IASA")
                    {
                        int ctr = 0;

                        int jx = 0;

                        int uh = 0;

                        using (var streamWriter = File.CreateText(mainWindow.txtBoxIASALocationPath.Text + "\\" + file.Name))
                        {
                            for (xy = 0; xy < lines.Count(); xy++)
                            {
                                if (lines[xy].Contains("ETCK"))
                                {
                                    jx = xy;


                                    if (Alines.Count != 0 && Tlines.Count != 0)
                                    {
                                        streamWriter.WriteLine("T-K" + Alines[ctr] + "-" + Tlines[ctr]);

                                        streamWriter.WriteLine("RM*ET/" + Tlines[ctr]);

                                        streamWriter.WriteLine("RM*NA/" + Alines[ctr] + "/PC1/V10000044");

                                        ctr++;
                                    }

                                }
                                else if (lines[xy].Contains("RM*FOP/CC/"))
                                {
                                    string tempCC = lines[xy].Substring(10, lines[xy].Length - 17);

                                    string decrpytedCC = "";

                                    Decrypt(tempCC, out decrpytedCC);

                                    var tempExpDate = lines[xy].Substring(lines[xy].Length - 7, 7);

                                    streamWriter.WriteLine("RM*FOP/CC/" + decrpytedCC + tempExpDate);
                                }
                                else
                                    streamWriter.WriteLine(lines[xy]);
                            }

                            streamWriter.Close();
                        }
                    }//end of else if IASA

                    //IATA
                    if (ctrLX == 3)
                    {
                        int chkIATA = 0;

                        for (int pp = 0; pp < lines.Count; pp++)
                        {
                            for (int i = 0; i < mainWindow.DGW1.Rows.Count; i++)
                            {
                                spClt = lines[pp].IndexOf(mainWindow.DGW1.Rows[i].Cells[0].Value.ToString());

                                if (spClt > 0)
                                {
                                    chkIATA = 1;
                                }
                            }
                        }
                        if (chkIATA == 1)
                        {
                            int ctr = 0;

                            double pubAmount = 0;

                            int comp = 0, chk = 0;

                            string sf = "";

                            double comAmount = 0, sfAmount = 0;

                            using (var streamWriter = File.CreateText(mainWindow.txtBoxSpecialClientLocationPath.Text
                            + "\\" + file.Name))
                            {

                                for (xy = 0; xy < lines.Count; xy++)
                                {

                                    if (lines[xy].Contains("K-"))
                                    {
                                        if (lines[xy].Length >= 32 && lines[xy].Substring(21, 10) != "")
                                            chk = 1;
                                        else
                                            chk = 2;
                                    }

                                    if (lines[xy].Contains("FM*M*"))
                                    {
                                        if (lines[xy].Length > 5)
                                        {
                                            comp = int.Parse(lines[xy].Substring(6, 1));

                                            chk = 1;
                                        }
                                        else if (lines[xy].Length == 5)
                                            chk = 2;

                                        if (chk == 1)
                                        {
                                            if (lines[xy].Contains("RM*SF/"))
                                            {
                                                sf = lines[xy];

                                                comAmount = (pubAmount * (comp / 100));

                                                sfAmount = pubAmount - comAmount;

                                                streamWriter.WriteLine(lines[xy].Replace(sf, "RM*SF/" + sfAmount));

                                                streamWriter.WriteLine("RM*CM/" + comAmount);

                                                xy++;
                                            }
                                        }
                                        else if (chk == 2)
                                        {
                                            if (lines[xy].Contains("RM*SF/"))
                                            {
                                                xy++;
                                            }
                                        }
                                        else
                                        {
                                            if (lines[xy].Contains("RM*SF/"))
                                            {
                                                sf = lines[xy];

                                                streamWriter.WriteLine(lines[xy].Replace(sf, "RM*CP/0"));

                                                streamWriter.WriteLine("RM*NF/0");
                                            }
                                        }

                                        if (lines[xy].Contains("TKOK") || lines[xy].Contains("TKTL"))
                                        {
                                            if (lines[xy].Contains("TKOK"))
                                            {
                                                var tktDate = lines[xy].Substring(4, 5);

                                                DateTime date = DateTime.Parse(tktDate);

                                                streamWriter.WriteLine("RM*FF65/" + string.Format("{0:MM-dd-yy}", date));
                                            }

                                            streamWriter.WriteLine("RM*PC/0/10000001");

                                            ctr++;
                                        }
                                        else if (lines[xy].Contains("RM*FOP/CC/"))
                                        {
                                            string tempCC = lines[xy].Substring(10, lines[xy].Length - 17);

                                            string decrpytedCC = "";

                                            Decrypt(tempCC, out decrpytedCC);

                                            var tempExpDate = lines[xy].Substring(lines[xy].Length - 7, 7);

                                            streamWriter.WriteLine("RM*FOP/CC/" + decrpytedCC + tempExpDate);
                                        }
                                        else
                                            streamWriter.WriteLine(lines[xy]);
                                    }
                                }
                                streamWriter.WriteLine("ENDX");

                                streamWriter.Close();
                            }//end of using
                        }//end of if
                        else
                        {
                            int ctr = 0;

                            using (var streamWriter = File.CreateText(mainWindow.txtBoxIATALocationPath.Text + "\\" + file.Name))
                            {
                                string netFare = "";
                                string segmentNoToBeRemove = "";

                                for (xy = 0; xy < lines.Count; xy++)
                                {
                                    if (lines[xy].Length > 2 && lines[xy].Substring(0,2).Contains("K-"))
                                    {
                                        string[] tempLine = lines[xy].Split(';');

                                        if(tempLine.Length > 1 && tempLine[1] != "")
                                            netFare = tempLine[1].Substring(3,tempLine[1].Length - 3).Replace(" ", "");
                                    }
                                    else if((lines[xy].Length > 2 && lines[xy].Substring(0,3).Contains("KN-")))
                                    {
                                        string[] tempLine = lines[xy].Split(';');

                                        if (tempLine.Length > 1 && tempLine[1] != "")
                                            netFare = tempLine[1].Substring(3, tempLine[1].Length - 3).Replace(" ", "");
                                    }

                                    if (lines[xy].Contains("TKOK") || lines[xy].Contains("TKTL"))
                                    {
                                        if (lines[xy].Contains("TKOK"))
                                        {
                                            var tktDate = lines[xy].Substring(4, 5);

                                            DateTime date = DateTime.Parse(tktDate);

                                            streamWriter.WriteLine("RM*FF65/" + string.Format("{0:MM-dd-yy}", date));
                                        }

                                        streamWriter.WriteLine("RM*PC/0/10000001");

                                        ctr++;
                                    }
                                    else if (lines[xy].Contains("RM*NF") && lines[xy].Contains("/*") && lines[xy].Contains(netFare))
                                    {
                                        string[] tempLine = lines[xy].Split('/');

                                        string line = tempLine[0] + "/" + tempLine[2];

                                        segmentNoToBeRemove = tempLine[1];

                                        streamWriter.WriteLine(line);
                                    }
                                    else if(segmentNoToBeRemove != "" && lines[xy].Contains(segmentNoToBeRemove))
                                    {
                                        lines[xy] = lines[xy].Replace("/" + segmentNoToBeRemove, "");

                                        streamWriter.WriteLine(lines[xy]);
                                    }
                                    else if (lines[xy].Contains("RM*FOP/CC/"))
                                    {
                                        string tempCC = lines[xy].Substring(10, lines[xy].Length - 17);

                                        string decrpytedCC = "";

                                        Decrypt(tempCC, out decrpytedCC);

                                        var tempExpDate = lines[xy].Substring(lines[xy].Length - 7, 7);

                                        streamWriter.WriteLine("RM*FOP/CC/" + decrpytedCC + tempExpDate);
                                    }
                                    else
                                    {
                                        streamWriter.WriteLine(lines[xy]);
                                    }
                                }

                                streamWriter.WriteLine("ENDX");

                                streamWriter.Close();
                            }//using
                        }
                    }


                }
            }//end of using clause
        //}//end of try clause
        //    catch (Exception error)
        //    {

        //    }
}//end of ReadAirFile function

        private bool CheckIfIASA(string _value)
        {
            //if (IASACode.FirstOrDefault(r => r.Contains(_value.ToUpper())) != null)
            //    return true;
            //else
            //    return false;

            bool returnVal = false;

            IASACode.ForEach(item =>
            {
                string code = ";" + item;

                if (_value.Contains(code))
                    returnVal = true;
            });

            return returnVal;
        }

        private int GetCTRLX(string _value)
        {
            bool temp = false;

            IASACode.ForEach(item =>
            {
                if (_value.IndexOf(item) > -1)
                    temp = true;
            });

            if (temp)
                return 3;
            else
                return 0;
        }
    }
}