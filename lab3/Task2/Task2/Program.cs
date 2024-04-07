using Task2;

IHero mage = new Mage();
Console.WriteLine("Mage abilities:");
mage.UseAbility();

Console.WriteLine("\nMage with armor:");
ArmorDecorator mageWithArmor = new ArmorDecorator(mage);
((ArmorDecorator)mageWithArmor).AddItem("Cloak of Protection");
((ArmorDecorator)mageWithArmor).ShowInventory();

IHero paladin = new Paladin();
Console.WriteLine("\nPaladin abilities:");
paladin.UseAbility();

Console.WriteLine("\nPaladin with armor:");
ArmorDecorator paladinWithArmor = new ArmorDecorator(paladin);
paladinWithArmor.AddItem("Plate Mail");
paladinWithArmor.ShowInventory();
Console.WriteLine("\nPaladin with artifacts:");
ArtifactDecorator paladinWithArtifacts = new ArtifactDecorator(paladin);
paladinWithArtifacts.AddItem("Holy Shield");
paladinWithArtifacts.ShowInventory();

IHero warrior = new Warrior();
Console.WriteLine("\nWarrior abilities:");
warrior.UseAbility();

Console.WriteLine("\nWarrior with weapons:");
WeaponDecorator warriorWithWeapons = new WeaponDecorator(warrior);
((WeaponDecorator)warriorWithWeapons).AddItem("Sword of Strength");
((WeaponDecorator)warriorWithWeapons).ShowInventory();