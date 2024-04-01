	What code smells did you see?
Rigidity: The Register method is too long and difficult to change. If the conditions for speaker approval change, it will cause a cascade of subsequent changes.
Fragility: Any changes within the Register method could lead to breaks and error in different places.
Immobility: The method Register is not reusable in other contexts or by other classes. It contains both business logic and repository interaction, limiting its mobility.
Needless Complexity: The God methos Register is hard to maintain.
Opacity: The code is hard to understand.

	What problems do you think the Speaker class has?
Poor Naming: Variable names like good, appr, nt, ot are not descriptive and make the code less readable. 
Hard-Coded Values: Some values, such as employer names, domains, and technology lists, are hard-coded within the class.
Direct Dependency on Repository: The Register method directly interacts with the repository for saving the speaker. 

	Which clean code principles (or general programming principles) did it violate?
Violation of SRP: The Speaker class is responsible for multiple tasks.
Separation of Concerns: The class does not separate concerns properly. It mixes data representation with business logic, validation, and exception handling.
KISS:The code contains unnecessary complexity and convoluted logic, making it harder to understand and maintain.
Violation of OCP: Some values, such as employer names, domains, and technology lists, are hard-coded within the class.

	What refactoring techniques did you use?
Separated methods with descriptive names to improve readability and promote code reuse.
Replaced Magic Numbers with named constants.
Created separate classes to adhere to the Single Responsibility Principle and improve maintainability.
Created common Interface for classes which share common behavior.
Implemented Repository classes responsible for data access and manipulation, such as SpeakerRepository, SessionRepository.
Created Services to encapsulate business logic.
