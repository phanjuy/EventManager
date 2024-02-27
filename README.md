# Problem statement
A department must make an event and need to register any registrations online.
You must be able to register for an event and see an overview of participants and
what they are registered for.

Possible events:
- Annual party
- Intro course to .Net
- Learning in databases

Requirements:
1. Create an event
2. Register a participant for an event
3. Get an overview of participants and what they are registered for.


# E/R modelling

Table `EVENT`
- EventId (PK)
- Name
- DateTime
- Description

Table `PARTICIPANT`
- ParticipantId (PK)
- FullName
- PhoneNumber
- EmailAddress

Table `EVENT_PARTICIPANT`
- EventId (FK)
- ParticipantId (FK)


# Data access layer

`EventRepository`
- `Event CreateEvent(Event event)`
- `List<Event> GetAllEvents()`

`ParticipantRepository`
- `Participant CreateParticipant(Participant participant)`

`EventParticipantRepository`
- `RegisterEvent(int participantId, int eventId)`
- `GetParticipantsForEachEvent()`
- `GetEventForEachParticipant()`

# Controllers

`EventController`
```
  POST    events/                   Create an event (1)
  GET     events/{id}               Read an event
  PUT     events/{id}               Update an event
  DELETE  events/{id}               Delete an event
  GET     events/{id}/participants  Read all participants for an event *
```

`ParticipantController`
```
  POST    participants/{id}         Create a participant
  GET     participants/{id}/events  Read all events for a participant
```

`RegistrationController`
```
  POST    registrations/                      Create an event (2)
  GET     registrations/events/participants/  Get participants for each event
  GET     registrations/participants/events/  Getevents for each participants
```

