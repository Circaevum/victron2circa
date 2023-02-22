﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTree : MonoBehaviour
{
    public GameObject BonsaiBranch;
    public GameObject BranchName;
    // Use this for initialization
    void Start()
    {

    }
    public void InstantiateButtonClicked()
    {
        DrawLine(new Vector3(0f, 0f, 0f), new Vector3(0f, 10f, 0f), 200000f, "C:");
        DrawLine(new Vector3(0f, 10f, 0f), new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), 50000f, "Program Files");
        DrawLine(new Vector3(0f, 10f, 0f), new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), 80000f, "Program Files (x86)");
        DrawLine(new Vector3(0f, 10f, 0f), new Vector3(-4.75528258147577f, 13.5355339059327f, 1.54508497187474f), 60000f, "Users");
        DrawLine(new Vector3(0f, 10f, 0f), new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), 9999f, "Windows");
        DrawLine(new Vector3(0f, 10f, 0f), new Vector3(-7.85398163418653E-05f, 13.5355339059327f, 4.99999999938315f), 1f, "setup.log");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(3.64166082260085f, 16.0355339059327f, 8.53440748680659f), 1351.35135135135f, "1");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(3.85372340806007f, 16.0355339059327f, 8.5253991787368f), 1351.35135135135f, "2");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(4.06521259452982f, 16.0355339059327f, 8.50739879617725f), 1351.35135135135f, "3");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(4.27574726420139f, 16.0355339059327f, 8.48043877703396f), 1351.35135135135f, "4");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(4.48494801936988f, 16.0355339059327f, 8.44456770508368f), 1351.35135135135f, "5");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(4.69243786613445f, 16.0355339059327f, 8.39985022242261f), 1351.35135135135f, "6");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(4.89784289376685f, 16.0355339059327f, 8.34636691297698f), 1351.35135135135f, "7");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(5.10079294852385f, 16.0355339059327f, 8.2842141572854f), 1351.35135135135f, "8");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(5.30092230068924f, 16.0355339059327f, 8.21350395881455f), 1351.35135135135f, "9");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(5.49787030364356f, 16.0355339059327f, 8.13436374212143f), 1351.35135135135f, "10");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(5.69128204377363f, 16.0355339059327f, 8.04693612322566f), 1351.35135135135f, "11");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(5.88080898005092f, 16.0355339059327f, 7.95137865260578f), 1351.35135135135f, "12");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(6.06610957212602f, 16.0355339059327f, 7.84786353128264f), 1351.35135135135f, "13");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(6.24684989580741f, 16.0355339059327f, 7.73657730050151f), 1351.35135135135f, "14");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(6.42270424481548f, 16.0355339059327f, 7.61772050557217f), 1351.35135135135f, "15");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(6.59335571772719f, 16.0355339059327f, 7.49150733447268f), 1351.35135135135f, "16");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(6.75849678905393f, 16.0355339059327f, 7.3581652318682f), 1351.35135135135f, "17");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(6.91782986342317f, 16.0355339059327f, 7.2179344892403f), 1351.35135135135f, "18");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.07106781186548f, 16.0355339059327f, 7.07106781186547f), 1351.35135135135f, "19");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.2179344892403f, 16.0355339059327f, 6.91782986342317f), 1351.35135135135f, "20");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.3581652318682f, 16.0355339059327f, 6.75849678905393f), 1351.35135135135f, "21");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.49150733447268f, 16.0355339059327f, 6.59335571772719f), 1351.35135135135f, "22");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.61772050557217f, 16.0355339059327f, 6.42270424481548f), 1351.35135135135f, "23");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.73657730050151f, 16.0355339059327f, 6.24684989580741f), 1351.35135135135f, "24");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.84786353128264f, 16.0355339059327f, 6.06610957212602f), 1351.35135135135f, "25");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(7.95137865260578f, 16.0355339059327f, 5.88080898005092f), 1351.35135135135f, "26");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.04693612322566f, 16.0355339059327f, 5.69128204377363f), 1351.35135135135f, "27");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.13436374212143f, 16.0355339059327f, 5.49787030364355f), 1351.35135135135f, "28");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.21350395881455f, 16.0355339059327f, 5.30092230068924f), 1351.35135135135f, "29");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.2842141572854f, 16.0355339059327f, 5.10079294852385f), 1351.35135135135f, "30");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.34636691297698f, 16.0355339059327f, 4.89784289376685f), 1351.35135135135f, "31");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.39985022242261f, 16.0355339059327f, 4.69243786613444f), 1351.35135135135f, "32");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.44456770508368f, 16.0355339059327f, 4.48494801936988f), 1351.35135135135f, "33");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.48043877703396f, 16.0355339059327f, 4.27574726420139f), 1351.35135135135f, "34");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.50739879617725f, 16.0355339059327f, 4.06521259452981f), 1351.35135135135f, "35");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.5253991787368f, 16.0355339059327f, 3.85372340806006f), 1351.35135135135f, "36");
        DrawLine(new Vector3(3.53553390593274f, 13.5355339059327f, 3.53553390593274f), new Vector3(8.53440748680658f, 16.0355339059327f, 3.64166082260085f), 1351.35135135135f, "37");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.54412117428506f, 16.0355339059327f, -4.85345104377891f), 1250f, "a1");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.53641302279832f, 16.0355339059327f, -5.04963659973172f), 1250f, "a2");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.52100860523572f, 16.0355339059327f, -5.24536828312358f), 1250f, "a3");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.49793167409262f, 16.0355339059327f, -5.44034428988561f), 1250f, "a4");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.46721781232419f, 16.0355339059327f, -5.63426398114754f), 1250f, "a5");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.4289143784791f, 16.0355339059327f, -5.82682834680103f), 1250f, "a6");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.38308043367604f, 16.0355339059327f, -6.01774046655156f), 1250f, "a7");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.32978665053578f, 16.0355339059327f, -6.20670596774808f), 1250f, "a8");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.26911520420913f, 16.0355339059327f, -6.39343347928424f), 1250f, "a9");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.20115964566875f, 16.0355339059327f, -6.57763508087152f), 1250f, "a10");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.12602475746041f, 16.0355339059327f, -6.75902674699148f), 1250f, "a11");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(6.04382639213584f, 16.0355339059327f, -6.93732878484248f), 1250f, "a12");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.95469129361651f, 16.0355339059327f, -7.11226626560576f), 1250f, "a13");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.85875690176369f, 16.0355339059327f, -7.28356944836569f), 1250f, "a14");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.75617114045617f, 16.0355339059327f, -7.45097419603077f), 1250f, "a15");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.6470921895023f, 16.0355339059327f, -7.61422238261383f), 1250f, "a16");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.53168824073827f, 16.0355339059327f, -7.77306229124363f), 1250f, "a17");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.41013723868842f, 16.0355339059327f, -7.927249002294f), 1250f, "a18");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.28262660618772f, 16.0355339059327f, -8.07654477103218f), 1250f, "a19");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.14935295538933f, 16.0355339059327f, -8.22071939420395f), 1250f, "a20");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(5.01052178460291f, 16.0355339059327f, -8.35955056499036f), 1250f, "a21");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(4.86634716143114f, 16.0355339059327f, -8.49282421578875f), 1250f, "a22");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(4.71705139269296f, 16.0355339059327f, -8.62033484828946f), 1250f, "a23");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(4.56286468164259f, 16.0355339059327f, -8.74188585033931f), 1250f, "a24");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(4.4040247730128f, 16.0355339059327f, -8.85728979910334f), 1250f, "a25");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(4.24077658642973f, 16.0355339059327f, -8.9663687500572f), 1250f, "a26");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(4.07337183876466f, 16.0355339059327f, -9.06895451136473f), 1250f, "a27");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(3.90206865600472f, 16.0355339059327f, -9.16488890321754f), 1250f, "a28");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(3.72713117524144f, 16.0355339059327f, -9.25402400173688f), 1250f, "a29");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(3.54882913739044f, 16.0355339059327f, -9.33622236706145f), 1250f, "a30");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(3.36743747127048f, 16.0355339059327f, -9.41135725526979f), 1250f, "a31");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(3.1832358696832f, 16.0355339059327f, -9.47931281381016f), 1250f, "a32");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(2.99650835814705f, 16.0355339059327f, -9.53998426013681f), 1250f, "a33");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(2.80754285695052f, 16.0355339059327f, -9.59327804327707f), 1250f, "a34");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(2.61663073719999f, 16.0355339059327f, -9.63911198808013f), 1250f, "a35");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(2.4240663715465f, 16.0355339059327f, -9.67741542192523f), 1250f, "a36");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(2.23014668028457f, 16.0355339059327f, -9.70812928369365f), 1250f, "a37");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(2.03517067352254f, 16.0355339059327f, -9.73120621483675f), 1250f, "a38");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(1.83943899013068f, 16.0355339059327f, -9.74661063239935f), 1250f, "a39");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(1.64325343417787f, 16.0355339059327f, -9.75431878388609f), 1250f, "a40");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(1.44691650957159f, 16.0355339059327f, -9.75431878388609f), 1250f, "a41");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(1.25073095361879f, 16.0355339059327f, -9.74661063239935f), 1250f, "a42");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(1.05499927022693f, 16.0355339059327f, -9.73120621483675f), 1250f, "a43");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(0.860023263464892f, 16.0355339059327f, -9.70812928369365f), 1250f, "a44");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(0.666103572202961f, 16.0355339059327f, -9.67741542192523f), 1250f, "a45");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(0.473539206549481f, 16.0355339059327f, -9.63911198808013f), 1250f, "a46");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(0.282627086798944f, 16.0355339059327f, -9.59327804327707f), 1250f, "a47");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(0.0936615856024225f, 16.0355339059327f, -9.53998426013681f), 1250f, "a48");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-0.0930659259337341f, 16.0355339059327f, -9.47931281381016f), 1250f, "a49");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-0.277267527521014f, 16.0355339059327f, -9.41135725526978f), 1250f, "a50");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-0.458659193640971f, 16.0355339059327f, -9.33622236706145f), 1250f, "a51");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-0.636961231491976f, 16.0355339059327f, -9.25402400173687f), 1250f, "a52");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-0.811898712255255f, 16.0355339059327f, -9.16488890321754f), 1250f, "a53");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-0.983201895015188f, 16.0355339059327f, -9.06895451136472f), 1250f, "a54");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-1.15060664268027f, 16.0355339059327f, -8.9663687500572f), 1250f, "a55");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-1.31385482926333f, 16.0355339059327f, -8.85728979910333f), 1250f, "a56");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-1.47269473789312f, 16.0355339059327f, -8.7418858503393f), 1250f, "a57");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-1.62688144894349f, 16.0355339059327f, -8.62033484828945f), 1250f, "a58");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-1.77617721768167f, 16.0355339059327f, -8.49282421578875f), 1250f, "a59");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-1.92035184085345f, 16.0355339059327f, -8.35955056499036f), 1250f, "a60");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-2.05918301163986f, 16.0355339059327f, -8.22071939420394f), 1250f, "a61");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-2.19245666243825f, 16.0355339059327f, -8.07654477103217f), 1250f, "a62");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-2.31996729493895f, 16.0355339059327f, -7.92724900229399f), 1250f, "a63");
        DrawLine(new Vector3(1.54508497187474f, 13.5355339059327f, -4.75528258147577f), new Vector3(-2.4415182969888f, 16.0355339059327f, -7.77306229124362f), 1250f, "a64");
        DrawLine(new Vector3(-4.75528258147577f, 13.5355339059327f, 1.54508497187474f), new Vector3(-9.51056516295154f, 16.0355339059327f, 2.44249065417534E-15f), 20000f, "Adam");
        DrawLine(new Vector3(-4.75528258147577f, 13.5355339059327f, 1.54508497187474f), new Vector3(-9.51056516295153f, 16.0355339059327f, 3.09016994374948f), 20000f, "Default");
        DrawLine(new Vector3(-4.75528258147577f, 13.5355339059327f, 1.54508497187474f), new Vector3(-7.69420884293813f, 16.0355339059327f, 5.59016994374948f), 20000f, "Public");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.31971163010494f, 16.0355339059327f, 9.69618218621768f), 102.030612244898f, "b1");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.30445332273936f, 16.0355339059327f, 9.70108589468018f), 102.030612244898f, "b2");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.28917937550685f, 16.0355339059327f, 9.70594066926672f), 102.030612244898f, "b3");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.27388994533945f, 16.0355339059327f, 9.71074646009697f), 102.030612244898f, "b4");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.2585851893283f, 16.0355339059327f, 9.71550321779386f), 102.030612244898f, "b5");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.24326526472199f, 16.0355339059327f, 9.72021089348412f), 102.030612244898f, "b6");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.22793032892496f, 16.0355339059327f, 9.72486943879878f), 102.030612244898f, "b7");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.2125805394959f, 16.0355339059327f, 9.72947880587365f), 102.030612244898f, "b8");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.19721605414607f, 16.0355339059327f, 9.73403894734982f), 102.030612244898f, "b9");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.18183703073777f, 16.0355339059327f, 9.73854981637417f), 102.030612244898f, "b10");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.16644362728265f, 16.0355339059327f, 9.7430113665998f), 102.030612244898f, "b11");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.15103600194012f, 16.0355339059327f, 9.74742355218654f), 102.030612244898f, "b12");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.1356143130157f, 16.0355339059327f, 9.75178632780144f), 102.030612244898f, "b13");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.1201787189594f, 16.0355339059327f, 9.75609964861918f), 102.030612244898f, "b14");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.10472937836411f, 16.0355339059327f, 9.7603634703226f), 102.030612244898f, "b15");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.08926644996396f, 16.0355339059327f, 9.76457774910309f), 102.030612244898f, "b16");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.07379009263269f, 16.0355339059327f, 9.76874244166106f), 102.030612244898f, "b17");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.058300465382f, 16.0355339059327f, 9.77285750520644f), 102.030612244898f, "b18");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.04279772735995f, 16.0355339059327f, 9.77692289745902f), 102.030612244898f, "b19");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.02728203784928f, 16.0355339059327f, 9.78093857664896f), 102.030612244898f, "b20");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-2.01175355626585f, 16.0355339059327f, 9.78490450151721f), 102.030612244898f, "b21");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.99621244215689f, 16.0355339059327f, 9.78882063131589f), 102.030612244898f, "b22");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.98065885519947f, 16.0355339059327f, 9.79268692580877f), 102.030612244898f, "b23");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.96509295519879f, 16.0355339059327f, 9.79650334527163f), 102.030612244898f, "b24");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.94951490208657f, 16.0355339059327f, 9.8002698504927f), 102.030612244898f, "b25");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.93392485591937f, 16.0355339059327f, 9.80398640277306f), 102.030612244898f, "b26");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.91832297687703f, 16.0355339059327f, 9.80765296392701f), 102.030612244898f, "b27");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.9027094252609f, 16.0355339059327f, 9.81126949628251f), 102.030612244898f, "b28");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.88708436149231f, 16.0355339059327f, 9.81483596268151f), 102.030612244898f, "b29");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.87144794611085f, 16.0355339059327f, 9.8183523264804f), 102.030612244898f, "b30");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.85580033977275f, 16.0355339059327f, 9.82181855155031f), 102.030612244898f, "b31");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.84014170324919f, 16.0355339059327f, 9.82523460227755f), 102.030612244898f, "b32");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.82447219742473f, 16.0355339059327f, 9.82860044356393f), 102.030612244898f, "b33");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.80879198329559f, 16.0355339059327f, 9.83191604082714f), 102.030612244898f, "b34");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.79310122196798f, 16.0355339059327f, 9.83518136000111f), 102.030612244898f, "b35");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.77740007465653f, 16.0355339059327f, 9.83839636753633f), 102.030612244898f, "b36");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.76168870268252f, 16.0355339059327f, 9.84156103040024f), 102.030612244898f, "b37");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.74596726747234f, 16.0355339059327f, 9.84467531607753f), 102.030612244898f, "b38");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.73023593055574f, 16.0355339059327f, 9.84773919257051f), 102.030612244898f, "b39");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.71449485356422f, 16.0355339059327f, 9.8507526283994f), 102.030612244898f, "b40");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.69874419822935f, 16.0355339059327f, 9.85371559260266f), 102.030612244898f, "b41");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.68298412638112f, 16.0355339059327f, 9.85662805473737f), 102.030612244898f, "b42");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.66721479994624f, 16.0355339059327f, 9.85948998487943f), 102.030612244898f, "b43");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.65143638094655f, 16.0355339059327f, 9.86230135362398f), 102.030612244898f, "b44");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.63564903149727f, 16.0355339059327f, 9.86506213208564f), 102.030612244898f, "b45");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.61985291380542f, 16.0355339059327f, 9.86777229189879f), 102.030612244898f, "b46");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.60404819016807f, 16.0355339059327f, 9.87043180521793f), 102.030612244898f, "b47");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.58823502297072f, 16.0355339059327f, 9.87304064471791f), 102.030612244898f, "b48");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.57241357468566f, 16.0355339059327f, 9.87559878359423f), 102.030612244898f, "b49");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.55658400787019f, 16.0355339059327f, 9.87810619556332f), 102.030612244898f, "b50");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.54074648516511f, 16.0355339059327f, 9.88056285486278f), 102.030612244898f, "b51");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.5249011692929f, 16.0355339059327f, 9.88296873625169f), 102.030612244898f, "b52");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.50904822305613f, 16.0355339059327f, 9.88532381501084f), 102.030612244898f, "b53");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.49318780933577f, 16.0355339059327f, 9.887628066943f), 102.030612244898f, "b54");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.47732009108952f, 16.0355339059327f, 9.88988146837315f), 102.030612244898f, "b55");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.46144523135012f, 16.0355339059327f, 9.89208399614872f), 102.030612244898f, "b56");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.4455633932237f, 16.0355339059327f, 9.89423562763987f), 102.030612244898f, "b57");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.42967473988806f, 16.0355339059327f, 9.89633634073968f), 102.030612244898f, "b58");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.41377943459106f, 16.0355339059327f, 9.89838611386438f), 102.030612244898f, "b59");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.39787764064887f, 16.0355339059327f, 9.90038492595361f), 102.030612244898f, "b60");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.38196952144437f, 16.0355339059327f, 9.90233275647057f), 102.030612244898f, "b61");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.36605524042537f, 16.0355339059327f, 9.9042295854023f), 102.030612244898f, "b62");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.35013496110305f, 16.0355339059327f, 9.90607539325985f), 102.030612244898f, "b63");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.33420884705018f, 16.0355339059327f, 9.90787016107848f), 102.030612244898f, "b64");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.3182770618995f, 16.0355339059327f, 9.90961387041786f), 102.030612244898f, "b65");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.302339769342f, 16.0355339059327f, 9.91130650336227f), 102.030612244898f, "b66");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.28639713312527f, 16.0355339059327f, 9.91294804252075f), 102.030612244898f, "b67");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.27044931705181f, 16.0355339059327f, 9.91453847102734f), 102.030612244898f, "b68");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.25449648497731f, 16.0355339059327f, 9.91607777254118f), 102.030612244898f, "b69");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.23853880080902f, 16.0355339059327f, 9.91756593124673f), 102.030612244898f, "b70");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.22257642850404f, 16.0355339059327f, 9.91900293185392f), 102.030612244898f, "b71");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.20660953206765f, 16.0355339059327f, 9.92038875959829f), 102.030612244898f, "b72");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.19063827555157f, 16.0355339059327f, 9.92172340024118f), 102.030612244898f, "b73");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.17466282305238f, 16.0355339059327f, 9.92300684006982f), 102.030612244898f, "b74");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.15868333870972f, 16.0355339059327f, 9.92423906589753f), 102.030612244898f, "b75");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.14269998670469f, 16.0355339059327f, 9.92542006506381f), 102.030612244898f, "b76");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.12671293125809f, 16.0355339059327f, 9.92654982543449f), 102.030612244898f, "b77");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.11072233662881f, 16.0355339059327f, 9.92762833540186f), 102.030612244898f, "b78");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.09472836711208f, 16.0355339059327f, 9.92865558388478f), 102.030612244898f, "b79");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.07873118703781f, 16.0355339059327f, 9.92963156032878f), 102.030612244898f, "b80");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.06273096076891f, 16.0355339059327f, 9.93055625470622f), 102.030612244898f, "b81");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.04672785269956f, 16.0355339059327f, 9.93142965751632f), 102.030612244898f, "b82");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.03072202725359f, 16.0355339059327f, 9.93225175978531f), 102.030612244898f, "b83");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-1.0147136488827f, 16.0355339059327f, 9.93302255306652f), 102.030612244898f, "b84");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.998702882064872f, 16.0355339059327f, 9.93374202944042f), 102.030612244898f, "b85");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.982689891302578f, 16.0355339059327f, 9.93441018151477f), 102.030612244898f, "b86");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.966674841121175f, 16.0355339059327f, 9.93502700242465f), 102.030612244898f, "b87");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.950657896067165f, 16.0355339059327f, 9.93559248583252f), 102.030612244898f, "b88");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.934639220706528f, 16.0355339059327f, 9.93610662592835f), 102.030612244898f, "b89");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.918618979623003f, 16.0355339059327f, 9.93656941742959f), 102.030612244898f, "b90");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.902597337416446f, 16.0355339059327f, 9.9369808555813f), 102.030612244898f, "b91");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.886574458701075f, 16.0355339059327f, 9.93734093615617f), 102.030612244898f, "b92");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.870550508103847f, 16.0355339059327f, 9.93764965545454f), 102.030612244898f, "b93");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.854525650262701f, 16.0355339059327f, 9.93790701030449f), 102.030612244898f, "b94");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.838500049824919f, 16.0355339059327f, 9.93811299806183f), 102.030612244898f, "b95");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.822473871445392f, 16.0355339059327f, 9.93826761661012f), 102.030612244898f, "b96");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.80644727978498f, 16.0355339059327f, 9.93837086436076f), 102.030612244898f, "b97");
        DrawLine(new Vector3(-0.782249897965531f, 13.5355339059327f, 4.93842941603228f), new Vector3(-0.790420439508753f, 16.0355339059327f, 9.93842274025291f), 102.030612244898f, "b98");


    }
    public void DrawLine(Vector3 root, Vector3 branch, float width, string name)
    {
        BonsaiBranch = GameObject.Find("BonsaiBranch");
        GameObject branch1 = Instantiate(BonsaiBranch);
        BranchName = GameObject.Find("BranchTextObject");
        GameObject branchname1 = Instantiate(BranchName);
        //Renderer rend = branch1.GetComponent<Renderer>();
        //rend.material.color = color1;

        branch1.GetComponent<BranchRenderer>().start = root;
        branch1.GetComponent<BranchRenderer>().stop = branch;
        branch1.GetComponent<BranchRenderer>().width = width/200000f;
        
        branchname1.GetComponent<BranchText>().start = root;
        branchname1.GetComponent<BranchText>().stop = branch;
        TextMesh text1 = branchname1.GetComponent<TextMesh>();
        text1.text = name;
    }
    // Update is called once per frame
    void Update()
    {

    }
}