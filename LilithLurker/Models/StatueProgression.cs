using System.Collections.Generic;

namespace LilithLurker.Models;

public class StatueProgression
{
    public StatueProgression()
    {
        Kehjistan = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 73.71212121212122, Top = 120.84848484848487, }},
            new LilithStatue{ Position = new Position { Left = 84.3939393939394, Top = 71.7575757575758, }},
            new LilithStatue{ Position = new Position { Left = 91.66666666666667, Top = 130.84848484848487, }},
            new LilithStatue{ Position = new Position { Left = 123.4848484848485, Top = 106.30303030303034, }},
            new LilithStatue{ Position = new Position { Left = 118.48484848484848, Top = 171.53030303030306, }},
            new LilithStatue{ Position = new Position { Left = 137.12121212121212, Top = 148.8030303030303, }},
            new LilithStatue{ Position = new Position { Left = 126.65319626609949, Top = 212.93374099019258, }},
            new LilithStatue{ Position = new Position { Left = 147.4596478790027, Top = 176.1595474418055, }},
            new LilithStatue{ Position = new Position { Left = 160.84674465319623, Top = 200.51438615148288, }},
            new LilithStatue{ Position = new Position { Left = 174.3951317499704, Top = 186.9659990547087, }},
            new LilithStatue{ Position = new Position { Left = 209.07255110480912, Top = 152.61116034503132, }},
            new LilithStatue{ Position = new Position { Left = 221.97577691126074, Top = 159.38535389341843, }},
            new LilithStatue{ Position = new Position { Left = 217.62093820158333, Top = 203.90148292567645, }},
            new LilithStatue{ Position = new Position { Left = 235.36287368545428, Top = 199.86922486116032, }},
            new LilithStatue{ Position = new Position { Left = 265.8467446531962, Top = 149.06277324825712, }},
            new LilithStatue{ Position = new Position { Left = 237.1185383244207, Top = 49.885026737967976, }},
            new LilithStatue{ Position = new Position { Left = 261.6185383244207, Top = 67.2183600713013, }},
            new LilithStatue{ Position = new Position { Left = 230.95187165775405, Top = 75.55169340463463, }},
            new LilithStatue{ Position = new Position { Left = 235.78520499108737, Top = 109.55169340463462, }},
            new LilithStatue{ Position = new Position { Left = 222.1185383244207, Top = 120.71836007130129, }},
            new LilithStatue{ Position = new Position { Left = 122.12637654742916, Top = 16.57763727500572, }},
            new LilithStatue{ Position = new Position { Left = 172.66209083314342, Top = 24.97049441786286, }},
            new LilithStatue{ Position = new Position { Left = 116.41209083314345, Top = 53.899065846434276, }},
            new LilithStatue{ Position = new Position { Left = 170.87637654742915, Top = 50.68478013214856, }},
            new LilithStatue{ Position = new Position { Left = 154.26923369028628, Top = 78.36335156071998, }},
            new LilithStatue{ Position = new Position { Left = 150.69780511885773, Top = 99.25620870357712, }},
            new LilithStatue{ Position = new Position { Left = 204.98351940457198, Top = 11.041922989291436, }},
            new LilithStatue{ Position = new Position { Left = 286.4120908331434, Top = 71.57763727500569, }},
            new LilithStatue{ Position = new Position { Left = 328.0192336902862, Top = 98.54192298929141, }},
            new LilithStatue{ Position = new Position { Left = 362.8406622617148, Top = 85.32763727500569, }},
            new LilithStatue{ Position = new Position { Left = 331.7692336902862, Top = 39.077637275005706, }},
        };

        FracturePeaks = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 46, Top = 43, }},
            new LilithStatue{ Position = new Position { Left = 82.3, Top = 30.3, }},
            new LilithStatue{ Position = new Position { Left = 112.2, Top = 33, }},
            new LilithStatue{ Position = new Position { Left = 138, Top = 59.5, }},
            new LilithStatue{ Position = new Position { Left = 166.2, Top = 60.5, }},
            new LilithStatue{ Position = new Position { Left = 157, Top = 87.5, }},
            new LilithStatue{ Position = new Position { Left = 196, Top = 103.8, }},
            new LilithStatue{ Position = new Position { Left = 50.8, Top = 71.3, }},
            new LilithStatue{ Position = new Position { Left = 84.5, Top = 82.3, }},
            new LilithStatue{ Position = new Position { Left = 85.8, Top = 132.8, }},
            new LilithStatue{ Position = new Position { Left = 98.3, Top = 139.6, }},
            new LilithStatue{ Position = new Position { Left = 131.7, Top = 144.2, }},
            new LilithStatue{ Position = new Position { Left = 113.6, Top = 161, }},
            new LilithStatue{ Position = new Position { Left = 50.8, Top = 139, }},
            new LilithStatue{ Position = new Position { Left = 160.2, Top = 187.3, }},
            new LilithStatue{ Position = new Position { Left = 210.20410538937298, Top = 154.90342510181114, }},
            new LilithStatue{ Position = new Position { Left = 248.873217243283, Top = 43.068362010796235, }},
            new LilithStatue{ Position = new Position { Left = 264.57801447444933, Top = 104.1122601976396, }},
            new LilithStatue{ Position = new Position { Left = 298.89619629263115, Top = 107.29407837945779, }},
            new LilithStatue{ Position = new Position { Left = 208.42307692307696, Top = 142.11538461538456, }},
            new LilithStatue{ Position = new Position { Left = 224.1923076923077, Top = 131.1538461538461, }},
            new LilithStatue{ Position = new Position { Left = 259.5769230769231, Top = 146.92307692307685, }},
            new LilithStatue{ Position = new Position { Left = 248.61538461538464, Top = 186.73076923076917, }},
            new LilithStatue{ Position = new Position { Left = 228.19333509125863, Top = 220.9139307916213, }},
            new LilithStatue{ Position = new Position { Left = 131.12712647187652, Top = 210.50296409477556, }},
            new LilithStatue{ Position = new Position { Left = 64.0082555000644, Top = 189.38046497227643, }},
            new LilithStatue{ Position = new Position { Left = 32.7961342879432, Top = 198.01682860864005, }},
            new LilithStatue{ Position = new Position { Left = 19.311285803094716, Top = 175.44107103288252, }},
        };

        Scosglen = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 25.791228070175617, Top = 188.988596491228, }},
            new LilithStatue{ Position = new Position { Left = 85.62456140350892, Top = 227.988596491228, }},
            new LilithStatue{ Position = new Position { Left = 77.95789473684226, Top = 180.82192982456135, }},
            new LilithStatue{ Position = new Position { Left = 123.62456140350892, Top = 239.15526315789464, }},
            new LilithStatue{ Position = new Position { Left = 73.95789473684226, Top = 142.82192982456135, }},
            new LilithStatue{ Position = new Position { Left = 72.95789473684226, Top = 128.1552631578947, }},
            new LilithStatue{ Position = new Position { Left = 96.29122807017559, Top = 104.32192982456138, }},
            new LilithStatue{ Position = new Position { Left = 118.79122807017559, Top = 71.32192982456138, }},
            new LilithStatue{ Position = new Position { Left = 140.12456140350892, Top = 18.155263157894744, }},
            new LilithStatue{ Position = new Position { Left = 145.62456140350892, Top = 30.8219298245614, }},
            new LilithStatue{ Position = new Position { Left = 174.1245614035089, Top = 52.821929824561394, }},
            new LilithStatue{ Position = new Position { Left = 188.29122807017558, Top = 69.48859649122805, }},
            new LilithStatue{ Position = new Position { Left = 206.79122807017555, Top = 108.98859649122804, }},
            new LilithStatue{ Position = new Position { Left = 249.62456140350886, Top = 125.32192982456138, }},
            new LilithStatue{ Position = new Position { Left = 287.62456140350884, Top = 130.6552631578947, }},
            new LilithStatue{ Position = new Position { Left = 295.2912280701755, Top = 135.82192982456138, }},
            new LilithStatue{ Position = new Position { Left = 341.95789473684215, Top = 173.488596491228, }},
            new LilithStatue{ Position = new Position { Left = 341.2912280701755, Top = 191.1552631578947, }},
            new LilithStatue{ Position = new Position { Left = 332.95789473684215, Top = 204.65526315789467, }},
            new LilithStatue{ Position = new Position { Left = 368.29122807017546, Top = 218.488596491228, }},
            new LilithStatue{ Position = new Position { Left = 320.12456140350884, Top = 238.32192982456132, }},
            new LilithStatue{ Position = new Position { Left = 112.42920203735142, Top = 200.84506427358713, }},
            new LilithStatue{ Position = new Position { Left = 134.36468590831913, Top = 171.32893524132908, }},
            new LilithStatue{ Position = new Position { Left = 125.17113752122236, Top = 148.26441911229685, }},
            new LilithStatue{ Position = new Position { Left = 189.04210526315782, Top = 149.87732233810328, }},
            new LilithStatue{ Position = new Position { Left = 220.97758913412554, Top = 159.39345137036133, }},
            new LilithStatue{ Position = new Position { Left = 249.2033955857384, Top = 199.07087072520005, }},
            new LilithStatue{ Position = new Position { Left = 274.5259762308997, Top = 183.74829008003877, }},
            new LilithStatue{ Position = new Position { Left = 251.46146010186743, Top = 235.0386126606839, }},
            new LilithStatue{ Position = new Position { Left = 180.07236842105254, Top = 217.76625664414055, }},
            new LilithStatue{ Position = new Position { Left = 189.8092105263157, Top = 222.37151980203527, }},
            new LilithStatue{ Position = new Position { Left = 221.2565789473683, Top = 219.08204611782477, }},
            new LilithStatue{ Position = new Position { Left = 295.2982034412954, Top = 217.2962414619543, }},
            new LilithStatue{ Position = new Position { Left = 295.4905111336031, Top = 254.7962414619543, }},
        };

        DrySteppes = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 54.32051282051283, Top = 200.98397435897434, }},
            new LilithStatue{ Position = new Position { Left = 50.282051282051285, Top = 148.86858974358975, }},
            new LilithStatue{ Position = new Position { Left = 96.43589743589743, Top = 219.2532051282051, }},
            new LilithStatue{ Position = new Position { Left = 110.28205128205127, Top = 145.98397435897436, }},
            new LilithStatue{ Position = new Position { Left = 159.89743589743586, Top = 241.9455128205128, }},
            new LilithStatue{ Position = new Position { Left = 181.62820512820508, Top = 206.94551282051282, }},
            new LilithStatue{ Position = new Position { Left = 214.32051282051276, Top = 216.94551282051282, }},
            new LilithStatue{ Position = new Position { Left = 217.7820512820512, Top = 246.9455128205128, }},
            new LilithStatue{ Position = new Position { Left = 313.9358974358973, Top = 261.7532051282051, }},
            new LilithStatue{ Position = new Position { Left = 294.128205128205, Top = 206.94551282051282, }},
            new LilithStatue{ Position = new Position { Left = 302.5897435897435, Top = 197.13782051282053, }},
            new LilithStatue{ Position = new Position { Left = 325.6666666666665, Top = 215.02243589743588, }},
            new LilithStatue{ Position = new Position { Left = 271.079365079365, Top = 190.38095238095246, }},
            new LilithStatue{ Position = new Position { Left = 264.17460317460313, Top = 166.80952380952388, }},
            new LilithStatue{ Position = new Position { Left = 241.31746031746027, Top = 166.3333333333334, }},
            new LilithStatue{ Position = new Position { Left = 231.07936507936503, Top = 138.71428571428578, }},
            new LilithStatue{ Position = new Position { Left = 312.7460317460317, Top = 148.71428571428578, }},
            new LilithStatue{ Position = new Position { Left = 340.3650793650793, Top = 138.00000000000006, }},
            new LilithStatue{ Position = new Position { Left = 330.12698412698404, Top = 99.66666666666674, }},
            new LilithStatue{ Position = new Position { Left = 274.8888888888888, Top = 66.57142857142867, }},
            new LilithStatue{ Position = new Position { Left = 257.0317460317459, Top = 93.23809523809533, }},
            new LilithStatue{ Position = new Position { Left = 239.65079365079356, Top = 73.71428571428581, }},
            new LilithStatue{ Position = new Position { Left = 230.36507936507928, Top = 86.33333333333343, }},
            new LilithStatue{ Position = new Position { Left = 222.03174603174597, Top = 82.28571428571438, }},
            new LilithStatue{ Position = new Position { Left = 213.8231505336768, Top = 179.65182186234819, }},
            new LilithStatue{ Position = new Position { Left = 171.09587780640408, Top = 151.92454913507544, }},
            new LilithStatue{ Position = new Position { Left = 211.09587780640408, Top = 134.42454913507547, }},
            new LilithStatue{ Position = new Position { Left = 192.2322414427677, Top = 128.2881854987118, }},
            new LilithStatue{ Position = new Position { Left = 149.05042326094954, Top = 120.56091277143909, }},
            new LilithStatue{ Position = new Position { Left = 196.55042326094951, Top = 106.01545822598456, }},
            new LilithStatue{ Position = new Position { Left = 161.71456183672873, Top = 85.18271746479701, }},
            new LilithStatue{ Position = new Position { Left = 216.80844155844161, Top = 11.861888111888096, }},
            new LilithStatue{ Position = new Position { Left = 104.1904473022827, Top = 95.27544715869519, }},
        };

        Hawezar = new List<LilithStatue>
        {
            new LilithStatue{ Position = new Position { Left = 22.431643625191935, Top = 148.2874276261373, }},
            new LilithStatue{ Position = new Position { Left = 66.14132104454674, Top = 119.09387923904052, }},
            new LilithStatue{ Position = new Position { Left = 75.98003072196609, Top = 64.09387923904055, }},
            new LilithStatue{ Position = new Position { Left = 155.0122887864822, Top = 30.868072787427664, }},
            new LilithStatue{ Position = new Position { Left = 204.2058371735789, Top = 11.674524400330903, }},
            new LilithStatue{ Position = new Position { Left = 233.0768049155144, Top = 12.48097601323413, }},
            new LilithStatue{ Position = new Position { Left = 276.62519201228855, Top = 33.61000827129863, }},
            new LilithStatue{ Position = new Position { Left = 252.91551459293373, Top = 46.99710504549218, }},
            new LilithStatue{ Position = new Position { Left = 287.1090629800305, Top = 47.96484698097604, }},
            new LilithStatue{ Position = new Position { Left = 338.8832565284175, Top = 78.28742762613732, }},
            new LilithStatue{ Position = new Position { Left = 340.496159754224, Top = 137.48097601323406, }},
            new LilithStatue{ Position = new Position { Left = 277.5929339477724, Top = 158.61000827129854, }},
            new LilithStatue{ Position = new Position { Left = 262.27035330261117, Top = 194.0938792390405, }},
            new LilithStatue{ Position = new Position { Left = 246.94777265744986, Top = 160.8680727874276, }},
            new LilithStatue{ Position = new Position { Left = 227.91551459293376, Top = 133.2874276261373, }},
            new LilithStatue{ Position = new Position { Left = 201.46390168970797, Top = 186.02936311000823, }},
            new LilithStatue{ Position = new Position { Left = 219.04454685099827, Top = 197.80355665839534, }},
            new LilithStatue{ Position = new Position { Left = 119.5904640856519, Top = 212.7260683185438, }},
            new LilithStatue{ Position = new Position { Left = 127.85969485488266, Top = 180.2260683185438, }},
            new LilithStatue{ Position = new Position { Left = 168.24431023949805, Top = 195.0337606262361, }},
            new LilithStatue{ Position = new Position { Left = 166.12892562411344, Top = 215.2260683185438, }},
            new LilithStatue{ Position = new Position { Left = 161.8981563933442, Top = 157.34145293392842, }},
            new LilithStatue{ Position = new Position { Left = 174.2058487010365, Top = 133.6876067800823, }},
            new LilithStatue{ Position = new Position { Left = 214.78277177795957, Top = 219.26452985700533, }},
            new LilithStatue{ Position = new Position { Left = 181.7058487010365, Top = 93.49529908777461, }},
            new LilithStatue{ Position = new Position { Left = 186.7058487010365, Top = 80.99529908777463, }},
            new LilithStatue{ Position = new Position { Left = 217.85969485488266, Top = 82.91837601085155, }},
            new LilithStatue{ Position = new Position { Left = 216.1289256241134, Top = 57.149145241620786, }},
            new LilithStatue{ Position = new Position { Left = 272.53656801630154, Top = 83.07024312920937, }},
            new LilithStatue{ Position = new Position { Left = 249.88950919277215, Top = 96.59965489391524, }},
            new LilithStatue{ Position = new Position { Left = 287.8306856633604, Top = 110.71730195273878, }},
            new LilithStatue{ Position = new Position { Left = 99.36279923978505, Top = 147.5867478305051, }},
            new LilithStatue{ Position = new Position { Left = 49.625957134521904, Top = 186.79727414629457, }},
            new LilithStatue{ Position = new Position { Left = 295.1531490352384, Top = 227.16967523259805, }},
        };
    }

    public List<LilithStatue> Kehjistan { get; set; }

    public List<LilithStatue> FracturePeaks { get; set; }

    public List<LilithStatue> Scosglen { get; set; }

    public List<LilithStatue> DrySteppes { get; set; }

    public List<LilithStatue> Hawezar { get; set; }
}
