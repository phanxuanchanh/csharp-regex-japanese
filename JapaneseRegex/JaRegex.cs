using System.Text.RegularExpressions;

namespace JapaneseRegex
{
    public class JaRegex
    {
        /// <summary>
        /// Unicode code points regex: [\x3041-\x3096]
        /// Unicode block property regex: \p{ Hiragana}
        /// ぁ あ ぃ い ぅ う ぇ え ぉ お か が き ぎ く ぐ け げ こ ご さ ざ し じ す ず せ ぜ そ ぞ た だ ち ぢ っ つ づ て で と ど な に ぬ ね の は ば ぱ ひ び ぴ ふ ぶ ぷ へ べ ぺ ほ ぼ ぽ ま み む め も ゃ や ゅ ゆ ょ よ ら り る れ ろ ゎ わ ゐ ゑ を ん ゔ ゕ ゖ  ゙ ゚ ゛ ゜ ゝ ゞ ゟ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsHiragana(string input)
        {
            return Regex.IsMatch(input, @"\p{IsHiragana}");
        }


        /// <summary>
        /// Katakana (Full Width)
        /// Unicode code points regex: [\x30A0-\x30FF]
        /// Unicode block property regex: \p{Katakana }
        /// ゠ ァ ア ィ イ ゥ ウ ェ エ ォ オ カ ガ キ ギ ク グ ケ ゲ コ ゴ サ ザ シ ジ ス ズ セ ゼ ソ ゾ タ ダ チ ヂ ッ ツ ヅ テ デ ト ド ナ ニ ヌ ネ ノ ハ バ パ ヒ ビ ピ フ ブ プ ヘ ベ ペ ホ ボ ポ マ ミ ム メ モ ャ ヤ ュ ユ ョ ヨ ラ リ ル レ ロ ヮ ワ ヰ ヱ ヲ ン ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsKatakana(string input)
        {
            return Regex.IsMatch(input, @"\p{IsKatakana}");
        }

        /// <summary>
        /// Katakana and Punctuation (Half Width)
        /// Unicode code points regex: [\xFF5F-\xFF9F]
        /// ｟ ｠ ｡ ｢ ｣ ､ ･ ｦ ｧ ｨ ｩ ｪ ｫ ｬ ｭ ｮ ｯ ｰ ｱ ｲ ｳ ｴ ｵ ｶ ｷ ｸ ｹ ｺ ｻ ｼ ｽ ｾ ｿ ﾀ ﾁ ﾂ ﾃ ﾄ ﾅ ﾆ ﾇ ﾈ ﾉ ﾊ ﾋ ﾌ ﾍ ﾎ ﾏ ﾐ ﾑ ﾒ ﾓ ﾔ ﾕ ﾖ ﾗ ﾘ ﾙ ﾚ ﾛ ﾜ ﾝ ﾞ
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsHalfWidthKatakana(string input)
        {
            return Regex.IsMatch(input, "[\xFF5F-\xFF9F]");
        }

        /// <summary>
        /// Kanji Radicals
        /// Unicode code points regex: [\x2E80-\x2FD5]
        /// ⺀ ⺁ ⺂ ⺃ ⺄ ⺅ ⺆ ⺇ ⺈ ⺉ ⺊ ⺋ ⺌ ⺍ ⺎ ⺏ ⺐ ⺑ ⺒ ⺓ ⺔ ⺕ ⺖ ⺗ ⺘ ⺙ ⺚ ⺛ ⺜ ⺝ ⺞ ⺟ ⺠ ⺡ ⺢ ⺣ ⺤ ⺥ ⺦ ⺧ ⺨ ⺩ ⺪ ⺫ ⺬ ⺭ ⺮ ⺯ ⺰ ⺱ ⺲ ⺳ ⺴ ⺵ ⺶ ⺷ ⺸ ⺹ ⺺ ⺻ ⺼ ⺽ ⺾ ⺿ ⻀ ⻁ ⻂ ⻃ ⻄ ⻅ ⻆ ⻇ ⻈ ⻉ ⻊ ⻋ ⻌ ⻍ ⻎ ⻏ ⻐ ⻑ ⻒ ⻓ ⻔ ⻕ ⻖ ⻗ ⻘ ⻙ ⻚ ⻛ ⻜ ⻝ ⻞ ⻟ ⻠ ⻡ ⻢ ⻣ ⻤ ⻥ ⻦ ⻧ ⻨ ⻩ ⻪ ⻫ ⻬ ⻭ ⻮ ⻯ ⻰ ⻱ ⻲ ⻳
        /// ⼀ ⼁ ⼂ ⼃ ⼄ ⼅ ⼆ ⼇ ⼈ ⼉ ⼊ ⼋ ⼌ ⼍ ⼎ ⼏ ⼐ ⼑ ⼒ ⼓ ⼔ ⼕ ⼖ ⼗ ⼘ ⼙ ⼚ ⼛ ⼜ ⼝ ⼞ ⼟ ⼠ ⼡ ⼢ ⼣ ⼤ ⼥ ⼦ ⼧ ⼨ ⼩ ⼪ ⼫ ⼬ ⼭ ⼮ ⼯ ⼰ ⼱ ⼲ ⼳ ⼴ ⼵ ⼶ ⼷ ⼸ ⼹ ⼺ ⼻ ⼼ ⼽ ⼾ ⼿ ⽀ ⽁ ⽂ ⽃ ⽄ ⽅ ⽆ ⽇ ⽈ ⽉ ⽊ ⽋ ⽌ ⽍ ⽎ ⽏ ⽐ ⽑ ⽒ ⽓ ⽔ ⽕ ⽖ ⽗ ⽘ ⽙ ⽚ ⽛ ⽜ ⽝ ⽞ ⽟ ⽠ ⽡ ⽢ ⽣ ⽤ ⽥ ⽦ ⽧ ⽨ ⽩ ⽪ ⽫ ⽬ ⽭ ⽮ ⽯ ⽰ ⽱ ⽲ ⽳ ⽴ ⽵ ⽶ ⽷ ⽸ ⽹ ⽺ ⽻ ⽼ ⽽ ⽾ ⽿ ⾀ ⾁ ⾂ ⾃ ⾄ ⾅ ⾆ ⾇ ⾈ ⾉ ⾊ ⾋ ⾌ ⾍ ⾎ ⾏ ⾐ ⾑ ⾒ ⾓ ⾔ ⾕ ⾖ ⾗ ⾘ ⾙ ⾚ ⾛ ⾜ ⾝ ⾞ ⾟ ⾠ ⾡ ⾢ ⾣ ⾤ ⾥ ⾦ ⾧ ⾨ ⾩ ⾪ ⾫ ⾬ ⾭ ⾮ ⾯ ⾰ ⾱ ⾲ ⾳ ⾴ ⾵ ⾶ ⾷ ⾸ ⾹ ⾺ ⾻ ⾼ ⾽ ⾾ ⾿ ⿀ ⿁ ⿂ ⿃ ⿄ ⿅ ⿆ ⿇ ⿈ ⿉ ⿊ ⿋ ⿌ ⿍ ⿎ ⿏ ⿐ ⿑ ⿒ ⿓ ⿔ ⿕
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsKanjiRadical(string input)
        {
            return Regex.IsMatch(input, "[\x2E80-\x2FD5]");
        }

        /// <summary>
        /// Kanji
        /// Unicode code points regex: [\x3400-\x4DB5\x4E00-\x9FCB\xF900-\xFA6A]
        /// Unicode block property regex: \p{Han}
        /// 一　二　三　百　千　万　円　日　桜　山　。。。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsKanji(string input)
        {
            return Regex.IsMatch(input, "[一-龯]");
        }

        /// <summary>
        /// Japanese Symbols and Punctuation
        /// Unicode code points regex: [\x3000-\x303F]
        /// 、 。 〃 〄 々 〆 〇 〈 〉 《 》 「 」 『 』 【 】 〒 〓 〔 〕 〖 〗 〘 〙 〚 〛 〜 〝 〞 〟 〠 〡 〢 〣 〤 〥 〦 〧 〨 〩 〪 〫 〬 〭 〮 〯 〰 〱 〲 〳 〴 〵 〶 〷 〸 〹 〺 〻 〼 〽 〾 〿
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsSymbols(string input)
        {
            return Regex.IsMatch(input, "[\x3000 -\x303F]");
        }

        /// <summary>
        /// Miscellaneous Japanese Symbols and Characters
        /// Unicode code points regex: [\x31F0-\x31FF\x3220-\x3243\x3280-\x337F]
        /// ㇰ ㇱ ㇲ ㇳ ㇴ ㇵ ㇶ ㇷ ㇸ ㇹ ㇺ ㇻ ㇼ ㇽ ㇾ ㇿ
        /// ㈠ ㈡ ㈢ ㈣ ㈤ ㈥ ㈦ ㈧ ㈨ ㈩ ㈪ ㈫ ㈬ ㈭ ㈮ ㈯ ㈰ ㈱ ㈲ ㈳ ㈴ ㈵ ㈶ ㈷ ㈸ ㈹ ㈺ ㈻ ㈼ ㈽ ㈾ ㈿ ㉀ ㉁ ㉂ ㉃
        /// ㊀ ㊁ ㊂ ㊃ ㊄ ㊅ ㊆ ㊇ ㊈ ㊉ ㊊ ㊋ ㊌ ㊍ ㊎ ㊏ ㊐ ㊑ ㊒ ㊓ ㊔ ㊕ ㊖ ㊗ ㊘ ㊙ ㊚ ㊛ ㊜ ㊝ ㊞ ㊟ ㊠ ㊡ ㊢ ㊣ ㊤ ㊥ ㊦ ㊧ ㊨ ㊩ ㊪ ㊫ ㊬ ㊭ ㊮ ㊯ ㊰ ㊱ ㊲ ㊳ ㊴ ㊵ ㊶ ㊷ ㊸ ㊹ ㊺ ㊻ ㊼ ㊽ ㊾ ㊿
        /// ㋀ ㋁ ㋂ ㋃ ㋄ ㋅ ㋆ ㋇ ㋈ ㋉ ㋊ ㋋  ㋐ ㋑ ㋒ ㋓ ㋔ ㋕ ㋖ ㋗ ㋘ ㋙ ㋚ ㋛ ㋜ ㋝ ㋞ ㋟ ㋠ ㋡ ㋢ ㋣ ㋤ ㋥ ㋦ ㋧ ㋨ ㋩ ㋪ ㋫ ㋬ ㋭ ㋮ ㋯ ㋰ ㋱ ㋲ ㋳ ㋴ ㋵ ㋶ ㋷ ㋸ ㋹ ㋺ ㋻ ㋼ ㋽ ㋾
        /// ㌀ ㌁ ㌂ ㌃ ㌄ ㌅ ㌆ ㌇ ㌈ ㌉ ㌊ ㌋ ㌌ ㌍ ㌎ ㌏ ㌐ ㌑ ㌒ ㌓ ㌔ ㌕ ㌖ ㌗ ㌘ ㌙ ㌚ ㌛ ㌜ ㌝ ㌞ ㌟ ㌠ ㌡ ㌢ ㌣ ㌤ ㌥ ㌦ ㌧ ㌨ ㌩ ㌪ ㌫ ㌬ ㌭ ㌮ ㌯ ㌰ ㌱ ㌲ ㌳ ㌴ ㌵ ㌶ ㌷ ㌸ ㌹ ㌺ ㌻ ㌼ ㌽ ㌾ ㌿ ㍀ ㍁ ㍂ ㍃ ㍄ ㍅ ㍆ ㍇ ㍈ ㍉ ㍊ ㍋ ㍌ ㍍ ㍎ ㍏ ㍐ ㍑ ㍒ ㍓ ㍔ ㍕ ㍖ ㍗ ㍘ ㍙ ㍚ ㍛ ㍜ ㍝ ㍞ ㍟ ㍠ ㍡ ㍢ ㍣ ㍤ ㍥ ㍦ ㍧ ㍨ ㍩ ㍪ ㍫ ㍬ ㍭ ㍮ ㍯ ㍰ ㍱ ㍲ ㍳ ㍴ ㍵ ㍶  ㍻ ㍼ ㍽ ㍾ ㍿
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMiscellaneousSymbols(string input)
        {
            return Regex.IsMatch(input, "[\x31F0 -\x31FF\x3220 -\x3243\x3280 -\x337F]");
        }

        /// <summary>
        /// Alphanumeric and Punctuation (Full Width)
        /// Unicode code points regex: [\xFF01-\xFF5E]
        /// ！ ＂ ＃ ＄ ％ ＆ ＇ （ ） ＊ ＋ ， － ． ／ ０ １ ２ ３ ４ ５ ６ ７ ８ ９ ： ； ＜ ＝ ＞ ？
        /// ＠ Ａ Ｂ Ｃ Ｄ Ｅ Ｆ Ｇ Ｈ Ｉ Ｊ Ｋ Ｌ Ｍ Ｎ Ｏ Ｐ Ｑ Ｒ Ｓ Ｔ Ｕ Ｖ Ｗ Ｘ Ｙ Ｚ ［ ＼ ］ ＾ ＿
        /// ｀ ａ ｂ ｃ ｄ ｅ ｆ ｇ ｈ ｉ ｊ ｋ ｌ ｍ ｎ ｏ ｐ ｑ ｒ ｓ ｔ ｕ ｖ ｗ ｘ ｙ ｚ ｛ ｜ ｝ ～";
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsAlphanumeric(string input)
        {
            return Regex.IsMatch(input, "[\xFF01-\xFF5E]");
        }

        /// <summary>
        /// Japanese Post Codes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsPostCode(string input)
        {
            return Regex.IsMatch(input, "/^¥d{3}-¥d{4}$|^¥d{3}-¥d{2}$|^¥d{3}$/");
        }

        /// <summary>
        /// Japanese fixed line phone numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsFixedLinePhoneNumber(string input)
        {
            return Regex.IsMatch(input, "/^¥d{1,4}-¥d{4}$|^¥d{2,5}-¥d{1,4}-¥d{4}$/")
                || Regex.IsMatch(input, "/^[0-9-]{6,9}$|^[0-9-]{12}$/\r\n/^¥d{1,4}-¥d{4}$|^¥d{2,5}-¥d{1,4}-¥d{4}$/");
        }

        /// <summary>
        /// Japanese mobile phone numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsMobilePhoneNumber(string input)
        {
            return Regex.IsMatch(input, "/^¥d{3}-¥d{4}-¥d{4}$|^¥d{11}$/")
                || Regex.IsMatch(input, "/^0¥d0-¥d{4}-¥d{4}$/");
        }
    }
}