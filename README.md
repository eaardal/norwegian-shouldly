# Norwegian Shouldly

A Norwegian language wrapper for the [Shouldly assertion framework](https://github.com/shouldly/shouldly). This wrapper contains no additional or changed functionality, it just translates english function- and parameter names into Norwegian for a more fluent experience when coding in Norwegian. It calls- and depends on the original Shouldly framework underneath and thus owns no logic other than that which Shouldly presents.

### Install

```
Install-Package NorwegianShouldly
```

### F.eks

```csharp
var person = new Person("Ola", "Normann", 30);
person.Fornavn.SkalVære("Ola");
person.Etternavn.SkalIkkeVæreNullEllerTom();
person.Alder.SkalVæreStørreEnn(18);

var personer = new List<Person>{ person };
personer.SkalIkkeVæreTom();
personer.SkalInneholde(person);
personer.Count.SkalVære(1);

class Dyr { };
class Hund : Dyr { };
var hund = new Hund();
hund.SkalVæreAvType<Hund>();
hund.SkalKunneTilordnes<Dyr>();
hund.SkalIkkeKunneTilordnes<NoeAnnet>();

var alder = 15;
alder.SkalVæreStørreEllerLik(18);
alder.SkalVæreMindreEnn(30);
alder.SkalVæreStørreEnn(3);

noe.Farlig().SkalKaste();
noe.MindreFarlig().SkalIkkeKaste();

var lipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
lipsum.SkalStarteMed("Lorem");
lipsum.SkalSlutteMed("elit");
lipsum.SkalInneholde("sit amet");
```
