# AllergyScore

#### (Brief Description of Application)

#### By (Your Name Here)

## Technologies Used

- _List all_
- _the major technologies_
- _you used in your project_
- _here_

## Description

## Setup/Installation Requirements

- _This is a great place_
- _to list setup instructions_
- _in a simple_
- _easy-to-understand_
- _format_

## Known Bugs

- _Any known issues_
- _should go here_

## License

## Contact Information

# BRAINSTORMING
## Prompt
- Build a website that uses a method that is called on someone's score.
  - The score is the object
  - The method returns an array listing what the user is allergic to. 

## Example
Running allergies(3) prints a list of the person's allergies (eggs and peanuts) to the screen.

## Planning
1. we want to check for each allergy
2. 

### Concept 1:
for each item1 in allergen{
  for each item2 in allergen{
    if allergyscore % item1 == item2
    {
      append item1 & item2
    } 
  }
}

### Concept 2:
foreach (item in list/array/dictionary?)
{
  if (currently_iterating_item's-value + next_item's-value !== userScore)
  {
    if (currently_iterating_item's-value + next_next_item-value !== userScore)
    {
      ... REPEAT TILL END OF LIST ...
    }
  }
  else
  {
    --> push each successful item to new array
    --> return array (then Console.WriteLine the array as a string to the user)
  }
}