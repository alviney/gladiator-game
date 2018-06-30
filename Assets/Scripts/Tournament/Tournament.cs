using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tournament {
    public string trackName;
    public int numberOfRaces;
    public int entryFee;

    public Tournament(string trackName, int numberOfRaces, int entryFee) {

        this.trackName = trackName;

        this.numberOfRaces = numberOfRaces;

        this.entryFee = entryFee;
    }
}
