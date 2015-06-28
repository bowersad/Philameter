$(function	()	{
	var birthConstant = 63.25;


	
	$(window).load(function(e)	{
	
		//Initial Animations
		var d = new Date();
		var dayStart = new Date(d.getFullYear(),d.getMonth(),d.getDate());
		var monthStart = new Date(d.getFullYear(),d.getMonth(),1);
		var yearStart = new Date(d.getFullYear(),1,1);		

		var currentBirthDaily = ((d - dayStart) / 86400000) * birthConstant;
		$({numberValue: 0}).animate({numberValue: currentBirthDaily}, {
			duration: 1000,
			easing: 'linear',
			step: function() { 
				$('#birthDaily').text(Math.ceil(this.numberValue)); 
			}
		});
		
		var currentBirthMonthly =  ((d - monthStart) / 86400000) * birthConstant;		
		$({numberValue: 0}).animate({numberValue: currentBirthMonthly}, {
			duration: 2000,
			easing: 'linear',
			step: function() { 
				$('#birthMonthly').text(Math.ceil(this.numberValue)); 
			}
		});
			
		var currentBirthAnnually =  ((d - yearStart) / 86400000) * birthConstant;		
		$({numberValue: 0}).animate({numberValue: currentBirthAnnually}, {
			duration: 4000,
			easing: 'linear',
			step: function() { 
				$('#birthAnnually').text(Math.ceil(this.numberValue)); 
			}
		});
	
	
		setInterval(function() {
			var currentNumber = $('#birthDaily').text();
			var d = new Date();
			var dayStart = new Date(d.getFullYear(),d.getMonth(),d.getDate());
			var newNumber = ((d - dayStart) / 86400000) * birthConstant;

			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 500,
				easing: 'linear',
				step: function() { 
					$('#BirthDaily').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 2000);
			
		setInterval(function() {
			var currentNumber = $('#birthMonthly').text();

			var d = new Date();
			var monthStart = new Date(d.getFullYear(),d.getMonth(),1);
			var time = d.getTime();
			var newNumber = ((d - monthStart) / 86400000) * birthConstant;
			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 1500,
				easing: 'linear',
				step: function() { 
					$('#birthMonthly').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 4500);

		setInterval(function() {
			var currentNumber = $('#birthAnnually').text();

			var d = new Date();
			var yearStart = new Date(d.getFullYear(),1,1);
			var time = d.getTime();
			var newNumber = ((d - yearStart) / 86400000) * birthConstant;
			$({numberValue: currentNumber}).animate({numberValue: newNumber}, {
				duration: 2500,
				easing: 'linear',
				step: function() { 
					$('#birthAnnually').text(Math.ceil(this.numberValue)); 
				}
			});
		}, 8500);					
		
	});
});
