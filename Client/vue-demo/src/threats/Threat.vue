<template>
    <div>
        <v-card>
            <v-container fluid grid-list-lg>
                <v-layout row wrap>

                   
                        <v-flex xs12 sm6  v-for="item in items">
                            <v-card color="blue-grey lighten-4" class="black--text">
                                <v-card-title primary-title>
                                    <div class="headline">{{item.name}}</div>
                                    <div>Listen to your favorite artists and albums whenever and wherever, online and offline.</div>
                                </v-card-title>
                                <v-card-actions>
                                    <v-btn flat dark>Listen now</v-btn>
                                </v-card-actions>
                            </v-card>
                        </v-flex>
                </v-layout>
            </v-container>
        </v-card>
    </div>
</template>
<script>
export default {
    name:"Threat",
    created(){
        let self  = this
        self.get()
    },
    data:() =>({
        items:[]
    }),
    methods:{

         get(){

            let self = this
            self.$store.state.services.ThreatService.getAll()
            .then(response => {
                console.log(response)
                self.items = response.data;
                console.log("los items");
                console.log(self.items);
                //self.form = response.data;
            }).catch(res  => {
                console.log(response);
            })
        }
    }

}
</script>
