// See https://aka.ms/new-console-template for more information

string[] example = [
    "--oooo-ooo--",
  "--xx--x--xx--",
  "--o---o--oo--",
  "--xx--x--ox--",
  "--xx--x--ox--"
];

BarbecueSkewers barbecueSkewers = new BarbecueSkewers();
Console.Write(barbecueSkewers.SepareSkewers(example));