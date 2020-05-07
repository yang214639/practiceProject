using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practiceProject.Areas.BoneHeavy.Models
{
    public class BvCalculate
    {
            public double year(int data)
            {
                double year = 0;
                //鼠、兔、馬、雞
                if (data == 1924 || data == 1984)
                    year = 1.2;
                if (data == 1927 || data == 1987)
                    year = 0.7;
                if (data == 1930 || data == 1990)
                    year = 0.9;
                if (data == 1933 || data == 1993)
                    year = 0.8;
                if (data == 1936 || data == 1996)
                    year = 1.6;
                if (data == 1939 || data == 1999)
                    year = 1.9;
                if (data == 1942 || data == 2002)
                    year = 0.8;
                if (data == 1945 || data == 2005)
                    year = 1.5;
                if (data == 1948 || data == 2008)
                    year = 1.5;
                if (data == 1951 || data == 2011)
                    year = 1.2;
                if (data == 1954 || data == 2014)
                    year = 1.5;
                if (data == 1957 || data == 2017)
                    year = 1.4;
                if (data == 1900 || data == 1960)
                    year = 0.7;
                if (data == 1903 || data == 1963)
                    year = 1.2;
                if (data == 1906 || data == 1966)
                    year = 1.3;
                if (data == 1909 || data == 1969)
                    year = 0.5;
                if (data == 1912 || data == 1972)
                    year = 0.5;
                if (data == 1915 || data == 1975)
                    year = 0.8;
                if (data == 1918 || data == 1978)
                    year = 1.9;
                if (data == 1921 || data == 1981)
                    year = 1.6;
                //牛、龍、羊、狗
                if (data == 1925 || data == 1985)
                    year = 0.9;
                if (data == 1928 || data == 1988)
                    year = 1.2;
                if (data == 1931 || data == 1991)
                    year = 0.8;
                if (data == 1934 || data == 1994)
                    year = 1.5;
                if (data == 1937 || data == 1997)
                    year = 0.8;
                if (data == 1940 || data == 2000)
                    year = 1.2;
                if (data == 1943 || data == 2003)
                    year = 0.7;
                if (data == 1946 || data == 2006)
                    year = 0.6;
                if (data == 1949 || data == 2009)
                    year = 0.7;
                if (data == 1952 || data == 2012)
                    year = 1.0;
                if (data == 1955 || data == 2015)
                    year = 0.6;
                if (data == 1958 || data == 2018)
                    year = 1.4;
                if (data == 1901 || data == 1961)
                    year = 0.7;
                if (data == 1904 || data == 1964)
                    year = 0.8;
                if (data == 1907 || data == 1967)
                    year = 0.5;
                if (data == 1910 || data == 1970)
                    year = 0.9;
                if (data == 1913 || data == 1973)
                    year = 0.7;
                if (data == 1916 || data == 1976)
                    year = 0.8;
                if (data == 1919 || data == 1979)
                    year = 0.6;
                if (data == 1922 || data == 1982)
                    year = 1;
                //虎、蛇、猴、豬
                if (data == 1926 || data == 1986)
                    year = 0.6;
                if (data == 1929 || data == 1989)
                    year = 0.5;
                if (data == 1932 || data == 1992)
                    year = 0.7;
                if (data == 1935 || data == 1995)
                    year = 0.9;
                if (data == 1938 || data == 1998)
                    year = 0.8;
                if (data == 1941 || data == 2001)
                    year = 0.6;
                if (data == 1944 || data == 2004)
                    year = 0.5;
                if (data == 1947 || data == 2007)
                    year = 1.6;
                if (data == 1950 || data == 2010)
                    year = 0.9;
                if (data == 1953 || data == 2013)
                    year = 0.7;
                if (data == 1956 || data == 2016)
                    year = 0.5;
                if (data == 1959 || data == 2019)
                    year = 0.9;
                if (data == 1902 || data == 1962)
                    year = 0.9;
                if (data == 1905 || data == 1965)
                    year = 0.7;
                if (data == 1908 || data == 1968)
                    year = 1.4;
                if (data == 1911 || data == 1971)
                    year = 1.7;
                if (data == 1914 || data == 1974)
                    year = 1.2;
                if (data == 1917 || data == 1977)
                    year = 0.6;
                if (data == 1920 || data == 1980)
                    year = 0.8;
                if (data == 1923 || data == 1983)
                    year = 0.6;
                return year;
            }



            public double month(int data)
            {
                // TODO Auto-generated method stub
                double ans = 0;

                if (data == 1)
                {
                    ans = ans + 0.6;
                }
                if (data == 2)
                {
                    ans = ans + 0.7;
                }
                if (data == 3)
                {
                    ans = ans + 1.8;
                }
                if (data == 4)
                {
                    ans = ans + 0.9;
                }
                if (data == 5)
                {
                    ans = ans + 0.5;
                }
                if (data == 6)
                {
                    ans = ans + 1.6;
                }
                if (data == 7)
                {
                    ans = ans + 0.9;
                }
                if (data == 8)
                {
                    ans = ans + 1.5;
                }
                if (data == 9)
                {
                    ans = ans + 1.8;
                }
                if (data == 10)
                {
                    ans = ans + 0.8;
                }
                if (data == 11)
                {
                    ans = ans + 0.9;
                }
                if (data == 12)
                {
                    ans = ans + 0.5;
                }
                return ans;

            }


            public double day(int data)
            {
                // TODO Auto-generated method stub
                double ans = 0;

                if (data == 1)
                {
                    ans = ans + 0.5;
                }
                if (data == 2)
                {
                    ans = ans + 1;
                }
                if (data == 3)
                {
                    ans = ans + 0.8;
                }
                if (data == 4)
                {
                    ans = ans + 1.5;
                }
                if (data == 5)
                {
                    ans = ans + 1.6;
                }
                if (data == 6)
                {
                    ans = ans + 1.5;
                }
                if (data == 7)
                {
                    ans = ans + 0.8;
                }
                if (data == 8)
                {
                    ans = ans + 1.6;
                }
                if (data == 9)
                {
                    ans = ans + 0.8;
                }
                if (data == 10)
                {
                    ans = ans + 1.6;
                }
                if (data == 11)
                {
                    ans = ans + 0.9;
                }
                if (data == 12)
                {
                    ans = ans + 1.7;
                }
                if (data == 13)
                {
                    ans = ans + 0.8;
                }
                if (data == 14)
                {
                    ans = ans + 1.7;
                }
                if (data == 15)
                {
                    ans = ans + 1;
                }
                if (data == 16)
                {
                    ans = ans + 0.8;
                }
                if (data == 17)
                {
                    ans = ans + 0.9;
                }
                if (data == 18)
                {
                    ans = ans + 1.8;
                }
                if (data == 19)
                {
                    ans = ans + 0.5;
                }
                if (data == 20)
                {
                    ans = ans + 1.5;
                }
                if (data == 21)
                {
                    ans = ans + 1;
                }
                if (data == 22)
                {
                    ans = ans + 0.9;
                }
                if (data == 23)
                {
                    ans = ans + 0.8;
                }
                if (data == 24)
                {
                    ans = ans + 0.9;
                }
                if (data == 25)
                {
                    ans = ans + 1.5;
                }
                if (data == 26)
                {
                    ans = ans + 1.8;
                }
                if (data == 27)
                {
                    ans = ans + 0.7;
                }
                if (data == 28)
                {
                    ans = ans + 0.8;
                }
                if (data == 29)
                {
                    ans = ans + 1.6;
                }
                if (data == 30)
                {
                    ans = ans + 0.6;
                }
                return ans;

            }

            public double born(String ch)
            {
                double born = 0;
                if (ch == "子")
                    born = 1.6;
                if (ch == "丑")
                    born = 0.6;
                if (ch == "寅")
                    born = 0.7;
                if (ch == "卯")
                    born = 1;
                if (ch == "辰")
                    born = 0.9;
                if (ch == "巳")
                    born = 1.6;
                if (ch == "午")
                    born = 1;
                if (ch == "未")
                    born = 0.8;
                if (ch == "申")
                    born = 0.8;
                if (ch == "酉")
                    born = 0.9;
                if (ch == "戌")
                    born = 0.6;
                if (ch == "亥")
                    born = 0.6;

                return born;

            }

            public String comment(double sum)
            {
                String tex = null;
                if (sum == 2.2)
                    tex = ("為乞丐命，孤苦伶仃，朝不保夕，吃不飽穿不暖，為人庸碌無能，一生行乞度過。");
                if (sum == 2.3)
                    tex = ("福氣不全，求謀作事卻一事難成，妻兒兄弟旨不可靠，離鄉別井投靠別人，尚可有兩餐溫飽。");
                if (sum == 2.4)
                    tex = ("福祿不全，出身貧苦，家道難有興旺的一日，親人沒有助力，宜出外謀事，但求三餐一宿。");
                if (sum == 2.5)
                    tex = ("祖蔭少，出身貧苦，六親無情冷漠，難以依靠，一生辛勞自食其力，尚且能得兩餐溫飽。");
                if (sum == 2.6)
                    tex = ("苦中掙扎，獨自為生活奔波勞碌，宜及早離家謀事，勤勤懇懇，晚年生活雖不富裕，但總算無憂。");
                if (sum == 2.7)
                    tex = ("祖蔭少，出身貧苦，少年已須靠自己到處闖，到處碰壁，多做少成，一生煩惱困苦無窮無盡。");
                if (sum == 2.8)
                    tex = ("出身貧苦，父母或家庭沒能大庇蔭，一生輾轉流離，飄泊無依，若無過繼他人，便是一生居無定所");
                if (sum == 2.9)
                    tex = ("早年運差，諸事欠順，四十歲後才可安身立命，名成利就，離鄉別井或改姓對運程有幫助。");
                if (sum == 3.0)
                    tex = ("一生勞碌奔波，為生計而苦苦掙扎，難有安定日子，須終身勤儉克苦，晚年才能稍有安穩。");
                if (sum == 3.1)
                    tex = ("早年謀事艱苦，家道貧寒，為生計而苦苦掙扎，中年後才見順利，興家立業，衣食尚算無憂。");
                if (sum == 3.2)
                    tex = ("早年運滯，諸事難成，後來漸有財源滾滾的一天，而中年後衣食不缺，名利雙收。");
                if (sum == 3.3)
                    tex = ("早年事事難成，半生辛勞謀事亦枉費心力，多做少成，至晚年運勢稍旺，衣食無憂。");
                if (sum == 3.4)
                    tex = ("在塵世福祿不全，為僧道之命，須離鄉別井，終身拜佛修道，多作善事才得善果。");
                if (sum == 3.5)
                    tex = ("福分不全，缺少家蔭，謀事須安守本份，不可好高鷔遠，待時來運到之時，自能衣食不缺。");
                if (sum == 3.6)
                    tex = ("早年福星高照，際遇非凡，並非庸碌無能之人，福分不淺，能靠自己能力出人頭地，諸事皆成。");
                if (sum == 3.7)
                    tex = ("事事難成，兄弟缺乏助力，須自食其力，一生辛勞亦難守微不足道的祖業，枉費心力。");
                if (sum == 3.8)
                    tex = ("骨格清高，聰明勤學，終能苦學成才，中年後有望擺脫貧苦，甚至踏足官場，或在大機構擔任要職。");
                if (sum == 3.9)
                    tex = ("終身運勢不通，多勞少成，儘管一生苦心竭力，克勤克儉營生，即使略有所成，到頭來還是無福享受。");
                if (sum == 4.0)
                    tex = ("早年雖吃苦，但注定福祿綿長，早年受過不少風霜挫折，猶幸為人聰明能幹，意志堅定，終能大器晚成。");
                if (sum == 4.1)
                    tex = ("︰為人聰明能幹，絕非池中物，早年運勢欠順，但中年運勢轉順，已能無憂無慮，逍遙自在。");
                if (sum == 4.2)
                    tex = ("早年運氣不順，為名利終日多思多慮，難以寬懷，中年後運勢漸順，名利齊來。");
                if (sum == 4.3)
                    tex = ("心思靈巧，聰明能幹，人品極佳，做事光明磊落，早注定衣祿豐厚，一生無須勞心勞神。");
                if (sum == 4.4)
                    tex = ("早年過份強求名利，奈何財運不順，但福份也是靠修來的，該放開胸懷，晚年便能無憂。");
                if (sum == 4.5)
                    tex = ("︰早年為名利奔波勞碌，中年後亦難以安定，一生難有兒女，晚年運須靠早年未雨綢繆。");
                if (sum == 4.6)
                    tex = ("父母沒有能力庇蔭，早年須離鄉別井穿州過省謀事，改姓或過繼他人運勢更佳，中年後衣食豐足。");
                if (sum == 4.7)
                    tex = ("福份綿長，無須為營生而終日勞碌，晚年運尤佳，妻 (夫) 榮子貴，生活無憂無慮，財源滾滾，豐衣足食。");
                if (sum == 4.8)
                    tex = ("早運不佳，蹉跎歲月，辛苦奔波，多勞少成，命帶孤苦，無依無靠，但晚年亦算興隆，衣食豐足。");
                if (sum == 4.9)
                    tex = ("福澤不淺，聰明自立，能靠雙手光宗耀祖，白手興家，晚年有名有利，有財有勢，受人敬仰。");
                if (sum == 5.0)
                    tex = ("為名利勞心勞力，難以安心，中年福祿亦不佳，但幾番辛苦之後，晚年財星高照，衣食豐足。");
                if (sum == 5.1)
                    tex = ("一生事事順遂，無須勞心勞神，親人皆有助力，一門顯赫，立業興家之時，福祿無窮。");
                if (sum == 5.2)
                    tex = ("家世顯赫，聰明有才幹，一世亨通，事事順利，無須勞苦奔波，自能光宗耀祖，家財萬貫。");
                if (sum == 5.3)
                    tex = ("福澤深厚，聰明有才幹，一生衣食無憂，立業興家，財源豐厚，富甲一方。");
                if (sum == 5.4)
                    tex = ("福澤深厚，出身書香世代，飽讀詩書，必能名成利就，豐衣足食，生活安穩，無憂無慮。");
                if (sum == 5.5)
                    tex = ("才幹非凡，從事武職 (紀律部隊) 爭名逐利，少年作事枉費心力，中年後富貴榮華，顯耀六親");
                if (sum == 5.6)
                    tex = ("人品非凡，胸懷磊落，早年嘗過不少苦楚，但福祿無窮，財源滾滾，晚年豐足。");
                if (sum == 5.7)
                    tex = ("福祿雙全，富貴長壽，品德完美的聖人，名聞於世，受萬人景仰，一生無憂無慮淡泊名利。");
                if (sum == 5.8)
                    tex = ("富貴福祿俱全，衣食自來，飽讀詩書，為高官厚祿之命，或在大機購中身居要職，執掌權柄。");
                if (sum == 5.9)
                    tex = ("聰明靈巧，出類拔萃，飽讀成才，在古代為狀元之命，從事武職 (紀律部隊) 功名顯赫。");
                if (sum == 6.0)
                    tex = ("聰明能幹，飽讀詩書，在古代必金榜提名，揚明立萬，顯耀宗親，衣食不缺，田產家財豐盛。");
                if (sum == 6.1)
                    tex = ("聰明能幹，天才橫溢，若非飽學成才，也必定富甲一方，成就非凡，舉世聞名，光宗耀祖。");
                if (sum == 6.2)
                    tex = ("福澤深厚，飽學成才，榮華富貴無窮無盡，在古代為卿相之命，威名顯赫，在現今也可解作掌權。");
                if (sum == 6.3)
                    tex = ("飽學成才，命格注定為官，或在大機購中掌權，福祿無窮，富貴榮華，家世興旺，一門顯赫。");
                if (sum == 6.4)
                    tex = ("古代為上書之命，能掌權威，富貴不盡，功名顯赫，在現今亦必為一國高官，政績超凡。");
                if (sum == 6.5)
                    tex = ("品格非凡，在古代為大將軍之命，建功立業，威名顯赫，在現今可解作從事武職而得威權。");
                if (sum == 6.6)
                    tex = ("出身富裕之家，福氣深厚，無須為名利煩惱，無憂無慮，亦可憑一己聰明而飽學成才。");
                if (sum == 6.7)
                    tex = ("出身顯赫富裕之家，福祿自然而至，家財冠世而聲望高，富可敵國，衣食豐足，事事順利。");
                if (sum == 6.8)
                    tex = ("生於富裕之家，家財萬貫，無須為名利愁煩，但才幹不凡，能靠自己能力使家業更鼎盛。");
                if (sum == 6.9)
                    tex = ("在古代為受封賜之命，在現代可以為官，亦可以是在大機購中受到賞識而掌權，富貴雙全，受人欽仰。");
                if (sum == 7.0)
                    tex = ("雖福份不輕，但終日勞心勞神，勞勞役役，追名逐利，其實注定富貴雙全，位高權重，名聞四海。");
                if (sum == 7.1)
                    tex = ("命格超凡，富貴雙全，在古代為公侯卿相之命，成就非凡，位高權重之餘，卻能無憂無慮。");

                return tex;
            }
            public double countWeight(int year, int month, int day, String time)
            {
                decimal sum = (decimal)this.year(year) + (decimal)this.month(month) + (decimal)this.day(day) + (decimal)this.born(time);
                return Convert.ToDouble(sum);
            }

        }
    
}