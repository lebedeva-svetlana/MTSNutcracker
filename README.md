# MTS Nutcracker

"Создай первую в мире сказку в коде!"

Пока компьютерные лингвисты учат AI превращать речь и текст в код, МТС запускает [челлендж](https://hr.mts.ru/word2code) — первый в мире контест по переводу новогодней сказки «Щелкунчик» на языки программирования. 

## Пример текста

> Крёстный на это сделал очень недовольную мину и процедил сквозь зубы:  
— Какая, однако, глупая штука вышла!

```csharp
Character Godfather = new("Godfather");
ActingCharacters.Add(Godfather);

Godfather.FacialExpression.Name = "displeased";
Godfather.FacialExpression.Power += 10;

Speech GodfatherSpeech = new()
{
    IsDirect = true,
    Emotion = new("through clenched teeth"),
    SpeechType = SpeechType.Incentive,
    Tense = Tense.Past,
    ObjectOfSpeech = new()
    {
        Name = "thing",
        Characteristic = "stupid"
    }
};
```

