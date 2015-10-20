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
```
