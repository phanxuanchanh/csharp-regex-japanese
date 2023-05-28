using JapaneseRegex;


string japaneseText1 = "ひらがな";
string japaneseText2 = "カタカナ";
string japaneseText3 = "ｶﾀｶﾅ";
string japaneseText4 = "⺢";
string japaneseText5 = "水";

bool isHiragana1 = JaRegex.IsHiragana(japaneseText1); //true
bool isHiragana2 = JaRegex.IsHiragana(japaneseText2); //false

bool isKatakana1 = JaRegex.IsKatakana(japaneseText1); //false
bool isKatakana2 = JaRegex.IsKatakana(japaneseText2); //true
bool isKatakana3 = JaRegex.IsKatakana(japaneseText3); //false

bool isHalfwidthKatakana1 = JaRegex.IsHalfWidthKatakana(japaneseText1); //false
bool isHalfwidthKatakana2 = JaRegex.IsHalfWidthKatakana(japaneseText2); //false
bool isHalfwidthKatakana3 = JaRegex.IsHalfWidthKatakana(japaneseText3); //true

bool isKanjiRadical1 = JaRegex.IsKanjiRadical(japaneseText4); //true
bool isKanjiRadical2 = JaRegex.IsKanjiRadical(japaneseText5); //false

bool isKanji1 = JaRegex.IsKanji(japaneseText4); //false
bool isKanji2 = JaRegex.IsKanji(japaneseText5); //true


Console.ReadKey();