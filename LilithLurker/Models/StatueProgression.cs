using System.Collections.Generic;

namespace LilithLurker.Models;

public class StatueProgression
{
    public StatueProgression()
    {
        Kehjistan = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 78.71212121212122, Top = 125.84848484848487, }}, 
            new LilithStatue{ Position = new Position { Left = 89.3939393939394, Top = 76.7575757575758, }}, 
            new LilithStatue{ Position = new Position { Left = 96.66666666666667, Top = 135.84848484848487, }}, 
            new LilithStatue{ Position = new Position { Left = 128.4848484848485, Top = 111.30303030303034, }}, 
            new LilithStatue{ Position = new Position { Left = 123.48484848484848, Top = 176.53030303030306, }}, 
            new LilithStatue{ Position = new Position { Left = 142.12121212121212, Top = 153.8030303030303, }}, 
            new LilithStatue{ Position = new Position { Left = 131.65319626609949, Top = 217.93374099019258, }}, 
            new LilithStatue{ Position = new Position { Left = 152.4596478790027, Top = 181.1595474418055, }}, 
            new LilithStatue{ Position = new Position { Left = 165.84674465319623, Top = 205.51438615148288, }}, 
            new LilithStatue{ Position = new Position { Left = 179.3951317499704, Top = 191.9659990547087, }}, 
            new LilithStatue{ Position = new Position { Left = 214.07255110480912, Top = 157.61116034503132, }}, 
            new LilithStatue{ Position = new Position { Left = 227.97577691126074, Top = 164.38535389341843, }}, 
            new LilithStatue{ Position = new Position { Left = 223.62093820158333, Top = 208.90148292567645, }}, 
            new LilithStatue{ Position = new Position { Left = 241.36287368545428, Top = 204.86922486116032, }}, 
            new LilithStatue{ Position = new Position { Left = 271.8467446531962, Top = 154.06277324825712, }}, 
            new LilithStatue{ Position = new Position { Left = 243.1185383244207, Top = 54.885026737967976, }}, 
            new LilithStatue{ Position = new Position { Left = 267.6185383244207, Top = 72.2183600713013, }},
            new LilithStatue{ Position = new Position { Left = 236.95187165775405, Top = 80.55169340463463, }}, 
            new LilithStatue{ Position = new Position { Left = 241.78520499108737, Top = 114.55169340463462, }}, 
            new LilithStatue{ Position = new Position { Left = 228.1185383244207, Top = 125.71836007130129, }}, 
            new LilithStatue{ Position = new Position { Left = 128.12637654742916, Top = 21.57763727500572, }}, 
            new LilithStatue{ Position = new Position { Left = 178.66209083314342, Top = 29.97049441786286, }}, 
            new LilithStatue{ Position = new Position { Left = 122.41209083314345, Top = 58.899065846434276, }}, 
            new LilithStatue{ Position = new Position { Left = 176.87637654742915, Top = 55.68478013214856, }}, 
            new LilithStatue{ Position = new Position { Left = 160.26923369028628, Top = 83.36335156071998, }}, 
            new LilithStatue{ Position = new Position { Left = 156.69780511885773, Top = 104.25620870357712, }}, 
            new LilithStatue{ Position = new Position { Left = 211.98351940457198, Top = 16.041922989291436, }}, 
            new LilithStatue{ Position = new Position { Left = 293.4120908331434, Top = 76.57763727500569, }}, 
            new LilithStatue{ Position = new Position { Left = 335.0192336902862, Top = 103.54192298929141, }}, 
            new LilithStatue{ Position = new Position { Left = 369.8406622617148, Top = 90.32763727500569, }}, 
            new LilithStatue{ Position = new Position { Left = 336.7692336902862, Top = 44.077637275005706, }},
        };

        FracturePeaks = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 51, Top = 48 }},
            new LilithStatue{ Position = new Position { Left = 87.3, Top = 35.3 }},
            new LilithStatue{ Position = new Position { Left = 117.2, Top = 38 }},
            new LilithStatue{ Position = new Position { Left = 143, Top = 64.5 }},
            new LilithStatue{ Position = new Position { Left = 171.2, Top = 65.5 }},
            new LilithStatue{ Position = new Position { Left = 162, Top = 92.5 }},
            new LilithStatue{ Position = new Position { Left = 201, Top = 108.8 }},
            new LilithStatue{ Position = new Position { Left = 55.8, Top = 76.3 }},
            new LilithStatue{ Position = new Position { Left = 89.5, Top = 87.3 }},
            new LilithStatue{ Position = new Position { Left = 90.8, Top = 137.8 }},
            new LilithStatue{ Position = new Position { Left = 103.3, Top = 144.6 }},
            new LilithStatue{ Position = new Position { Left = 136.7, Top = 149.2 }},
            new LilithStatue{ Position = new Position { Left = 118.6, Top = 166 }},
            new LilithStatue{ Position = new Position { Left = 55.8, Top = 144 }},
            new LilithStatue{ Position = new Position { Left = 165.2, Top = 192.3 }},
            new LilithStatue{ Position = new Position { Left = 215.204105389373, Top = 159.90342510181115 }},
            new LilithStatue{ Position = new Position { Left = 253.87321724328301, Top = 48.06836201079624 }},
            new LilithStatue{ Position = new Position { Left = 269.57801447444936, Top = 109.1122601976396 }},
            new LilithStatue{ Position = new Position { Left = 303.89619629263116, Top = 112.2940783794578 }},
            new LilithStatue{ Position = new Position { Left = 213.423076923077, Top = 147.11538461538456 }},
            new LilithStatue{ Position = new Position { Left = 229.19230769230775, Top = 136.1538461538461 }},
            new LilithStatue{ Position = new Position { Left = 264.5769230769231, Top = 151.92307692307685 }},
            new LilithStatue{ Position = new Position { Left = 253.61538461538467, Top = 191.73076923076917 }},
            new LilithStatue{ Position = new Position { Left = 233.19333509125865, Top = 225.9139307916213 }},
            new LilithStatue{ Position = new Position { Left = 136.12712647187654, Top = 215.50296409477557 }},
            new LilithStatue{ Position = new Position { Left = 69.00825550006442, Top = 194.38046497227644 }},
            new LilithStatue{ Position = new Position { Left = 37.79613428794321, Top = 203.01682860864006 }},
            new LilithStatue{ Position = new Position { Left = 24.311285803094718, Top = 180.44107103288253 }}
        };

        Scosglen = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 30.791228070175617, Top = 193.988596491228, }}, 
            new LilithStatue{ Position = new Position { Left = 90.62456140350892, Top = 232.988596491228, }}, 
            new LilithStatue{ Position = new Position { Left = 82.95789473684226, Top = 185.82192982456135, }}, 
            new LilithStatue{ Position = new Position { Left = 128.62456140350892, Top = 244.15526315789464, }}, 
            new LilithStatue{ Position = new Position { Left = 78.95789473684226, Top = 147.82192982456135, }}, 
            new LilithStatue{ Position = new Position { Left = 77.95789473684226, Top = 133.1552631578947, }}, 
            new LilithStatue{ Position = new Position { Left = 101.29122807017559, Top = 109.32192982456138, }}, 
            new LilithStatue{ Position = new Position { Left = 123.79122807017559, Top = 76.32192982456138, }}, 
            new LilithStatue{ Position = new Position { Left = 145.12456140350892, Top = 23.155263157894744, }}, 
            new LilithStatue{ Position = new Position { Left = 150.62456140350892, Top = 35.8219298245614, }}, 
            new LilithStatue{ Position = new Position { Left = 179.1245614035089, Top = 57.821929824561394, }}, 
            new LilithStatue{ Position = new Position { Left = 193.29122807017558, Top = 74.48859649122805, }}, 
            new LilithStatue{ Position = new Position { Left = 211.79122807017555, Top = 113.98859649122804, }}, 
            new LilithStatue{ Position = new Position { Left = 254.62456140350886, Top = 130.32192982456138, }}, 
            new LilithStatue{ Position = new Position { Left = 292.62456140350884, Top = 135.6552631578947, }}, 
            new LilithStatue{ Position = new Position { Left = 300.2912280701755, Top = 140.82192982456138, }}, 
            new LilithStatue{ Position = new Position { Left = 346.95789473684215, Top = 178.488596491228, }}, 
            new LilithStatue{ Position = new Position { Left = 346.2912280701755, Top = 196.1552631578947, }}, 
            new LilithStatue{ Position = new Position { Left = 337.95789473684215, Top = 209.65526315789467, }}, 
            new LilithStatue{ Position = new Position { Left = 373.29122807017546, Top = 223.488596491228, }}, 
            new LilithStatue{ Position = new Position { Left = 325.12456140350884, Top = 243.32192982456132, }}, 
            new LilithStatue{ Position = new Position { Left = 117.42920203735142, Top = 205.84506427358713, }}, 
            new LilithStatue{ Position = new Position { Left = 139.36468590831913, Top = 176.32893524132908, }}, 
            new LilithStatue{ Position = new Position { Left = 130.17113752122236, Top = 153.26441911229685, }}, 
            new LilithStatue{ Position = new Position { Left = 194.04210526315782, Top = 154.87732233810328, }}, 
            new LilithStatue{ Position = new Position { Left = 225.97758913412554, Top = 164.39345137036133, }}, 
            new LilithStatue{ Position = new Position { Left = 254.2033955857384, Top = 204.07087072520005, }}, 
            new LilithStatue{ Position = new Position { Left = 279.5259762308997, Top = 188.74829008003877, }}, 
            new LilithStatue{ Position = new Position { Left = 256.46146010186743, Top = 240.0386126606839, }}, 
            new LilithStatue{ Position = new Position { Left = 185.07236842105254, Top = 222.76625664414055, }}, 
            new LilithStatue{ Position = new Position { Left = 194.8092105263157, Top = 227.37151980203527, }}, 
            new LilithStatue{ Position = new Position { Left = 226.2565789473683, Top = 224.08204611782477, }}, 
            new LilithStatue{ Position = new Position { Left = 300.2982034412954, Top = 222.2962414619543, }}, 
            new LilithStatue{ Position = new Position { Left = 300.4905111336031, Top = 259.7962414619543, }},
        };

        DrySteppes = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 59.32051282051283, Top = 205.98397435897434, }}, 
            new LilithStatue{ Position = new Position { Left = 55.282051282051285, Top = 153.86858974358975, }}, 
            new LilithStatue{ Position = new Position { Left = 101.43589743589743, Top = 224.2532051282051, }}, 
            new LilithStatue{ Position = new Position { Left = 115.28205128205127, Top = 150.98397435897436, }}, 
            new LilithStatue{ Position = new Position { Left = 164.89743589743586, Top = 246.9455128205128, }}, 
            new LilithStatue{ Position = new Position { Left = 186.62820512820508, Top = 211.94551282051282, }}, 
            new LilithStatue{ Position = new Position { Left = 219.32051282051276, Top = 221.94551282051282, }}, 
            new LilithStatue{ Position = new Position { Left = 222.7820512820512, Top = 251.9455128205128, }},
            new LilithStatue{ Position = new Position { Left = 318.9358974358973, Top = 266.7532051282051, }}, 
            new LilithStatue{ Position = new Position { Left = 299.128205128205, Top = 211.94551282051282, }}, 
            new LilithStatue{ Position = new Position { Left = 307.5897435897435, Top = 202.13782051282053, }}, 
            new LilithStatue{ Position = new Position { Left = 330.6666666666665, Top = 220.02243589743588, }}, 
            new LilithStatue{ Position = new Position { Left = 276.079365079365, Top = 195.38095238095246, }}, 
            new LilithStatue{ Position = new Position { Left = 269.17460317460313, Top = 171.80952380952388, }}, 
            new LilithStatue{ Position = new Position { Left = 246.31746031746027, Top = 171.3333333333334, }}, 
            new LilithStatue{ Position = new Position { Left = 236.07936507936503, Top = 143.71428571428578, }}, 
            new LilithStatue{ Position = new Position { Left = 317.7460317460317, Top = 153.71428571428578, }}, 
            new LilithStatue{ Position = new Position { Left = 345.3650793650793, Top = 143.00000000000006, }}, 
            new LilithStatue{ Position = new Position { Left = 335.12698412698404, Top = 104.66666666666674, }}, 
            new LilithStatue{ Position = new Position { Left = 279.8888888888888, Top = 71.57142857142867, }}, 
            new LilithStatue{ Position = new Position { Left = 262.0317460317459, Top = 98.23809523809533, }}, 
            new LilithStatue{ Position = new Position { Left = 244.65079365079356, Top = 78.71428571428581, }}, 
            new LilithStatue{ Position = new Position { Left = 235.36507936507928, Top = 91.33333333333343, }}, 
            new LilithStatue{ Position = new Position { Left = 227.03174603174597, Top = 87.28571428571438, }}, 
            new LilithStatue{ Position = new Position { Left = 218.8231505336768, Top = 184.65182186234819, }}, 
            new LilithStatue{ Position = new Position { Left = 176.09587780640408, Top = 156.92454913507544, }}, 
            new LilithStatue{ Position = new Position { Left = 216.09587780640408, Top = 139.42454913507547, }}, 
            new LilithStatue{ Position = new Position { Left = 197.2322414427677, Top = 133.2881854987118, }}, 
            new LilithStatue{ Position = new Position { Left = 154.05042326094954, Top = 125.56091277143909, }}, 
            new LilithStatue{ Position = new Position { Left = 201.55042326094951, Top = 111.01545822598456, }}, 
            new LilithStatue{ Position = new Position { Left = 166.71456183672873, Top = 90.18271746479701, }}, 
            new LilithStatue{ Position = new Position { Left = 221.80844155844161, Top = 16.861888111888096, }}, 
            new LilithStatue{ Position = new Position { Left = 109.1904473022827, Top = 100.27544715869519, }},
        };

        Hawezar = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 27.431643625191935, Top = 153.2874276261373, }}, 
            new LilithStatue{ Position = new Position { Left = 71.14132104454674, Top = 124.09387923904052, }}, 
            new LilithStatue{ Position = new Position { Left = 80.98003072196609, Top = 69.09387923904055, }}, 
            new LilithStatue{ Position = new Position { Left = 160.0122887864822, Top = 35.868072787427664, }}, 
            new LilithStatue{ Position = new Position { Left = 209.2058371735789, Top = 16.674524400330903, }}, 
            new LilithStatue{ Position = new Position { Left = 238.0768049155144, Top = 17.48097601323413, }}, 
            new LilithStatue{ Position = new Position { Left = 281.62519201228855, Top = 38.61000827129863, }}, 
            new LilithStatue{ Position = new Position { Left = 257.91551459293373, Top = 51.99710504549218, }}, 
            new LilithStatue{ Position = new Position { Left = 292.1090629800305, Top = 52.96484698097604, }}, 
            new LilithStatue{ Position = new Position { Left = 343.8832565284175, Top = 83.28742762613732, }}, 
            new LilithStatue{ Position = new Position { Left = 345.496159754224, Top = 142.48097601323406, }}, 
            new LilithStatue{ Position = new Position { Left = 282.5929339477724, Top = 163.61000827129854, }},
            new LilithStatue{ Position = new Position { Left = 267.27035330261117, Top = 199.0938792390405, }},
            new LilithStatue{ Position = new Position { Left = 251.94777265744986, Top = 165.8680727874276, }},
            new LilithStatue{ Position = new Position { Left = 232.91551459293376, Top = 138.2874276261373, }},
            new LilithStatue{ Position = new Position { Left = 206.46390168970797, Top = 191.02936311000823, }},
            new LilithStatue{ Position = new Position { Left = 224.04454685099827, Top = 202.80355665839534, }},
            new LilithStatue{ Position = new Position { Left = 124.5904640856519, Top = 217.7260683185438, }},
            new LilithStatue{ Position = new Position { Left = 132.85969485488266, Top = 185.2260683185438, }},
            new LilithStatue{ Position = new Position { Left = 173.24431023949805, Top = 200.0337606262361, }},
            new LilithStatue{ Position = new Position { Left = 171.12892562411344, Top = 220.2260683185438, }},
            new LilithStatue{ Position = new Position { Left = 166.8981563933442, Top = 162.34145293392842, }},
            new LilithStatue{ Position = new Position { Left = 179.2058487010365, Top = 138.6876067800823, }},
            new LilithStatue{ Position = new Position { Left = 219.78277177795957, Top = 224.26452985700533, }},
            new LilithStatue{ Position = new Position { Left = 186.7058487010365, Top = 98.49529908777461, }},
            new LilithStatue{ Position = new Position { Left = 191.7058487010365, Top = 85.99529908777463, }},
            new LilithStatue{ Position = new Position { Left = 222.85969485488266, Top = 87.91837601085155, }},
            new LilithStatue{ Position = new Position { Left = 221.1289256241134, Top = 62.149145241620786, }},
            new LilithStatue{ Position = new Position { Left = 277.53656801630154, Top = 88.07024312920937, }},
            new LilithStatue{ Position = new Position { Left = 254.88950919277215, Top = 101.59965489391524, }},
            new LilithStatue{ Position = new Position { Left = 292.8306856633604, Top = 115.71730195273878, }},
            new LilithStatue{ Position = new Position { Left = 104.36279923978505, Top = 152.5867478305051, }},
            new LilithStatue{ Position = new Position { Left = 54.625957134521904, Top = 191.79727414629457, }},
            new LilithStatue{ Position = new Position { Left = 300.1531490352384, Top = 232.16967523259805, }},
        };
    }

    public List<LilithStatue> Kehjistan { get; set; }

    public List<LilithStatue> FracturePeaks { get; set; }

    public List<LilithStatue> Scosglen { get; set; }

    public List<LilithStatue> DrySteppes { get; set; }

    public List<LilithStatue> Hawezar { get; set; }
}
